using AutoMapper;
using IndexFund.Common.WebApi.Entities;
using IndexFund.Common.WebApi.Models;
using IndexFund.Common.WebApi.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace IndexFund.Common.WebApi.Controllers
{
    [Route("api/category")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryRepository categoryRepository;
        private readonly IMapper mapper;
        private readonly ProblemDetailsFactory problemDetailsFactory;

        public CategoryController(ICategoryRepository categoryRepository, IMapper mapper, ProblemDetailsFactory problemDetailsFactory)
        {
            this.categoryRepository = categoryRepository ?? throw new ArgumentNullException(nameof(categoryRepository));
            this.mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            this.problemDetailsFactory = problemDetailsFactory ?? throw new ArgumentNullException(nameof(problemDetailsFactory));
        }

        [HttpGet(Name = "GetCategories")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<CategoryDTO>>> GetCategories()
        {
            return Ok(mapper.Map<IEnumerable<CategoryDTO>>(await categoryRepository.GetCategoriesAsync()));
        }

        [HttpGet("{Id}", Name = "GetCategory")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetCategory(int Id)
        {
            var category = await categoryRepository.GetCategoryAsync(Id);

            return category is null ? NotFound() : Ok(mapper.Map<CategoryDTO>(category));
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status406NotAcceptable)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<ActionResult<CategoryDTO>> CreateCategory(CategoryForCreationDTO category)
        {
            var createdCategory = mapper.Map<Category>(category);
            if (await categoryRepository.CategoryExistsAsync(createdCategory))
            {

                return BadRequest(
                problemDetailsFactory.CreateProblemDetails(HttpContext,
                    statusCode: 406,
                    detail: $"""Provided category "{createdCategory.Name}" exists in database."""));
            }
            await categoryRepository.CreateCategoryAsync(createdCategory);
            await categoryRepository.SaveChangesAsync();

            return CreatedAtRoute("GetCategory", new { Id = createdCategory.Id },mapper.Map<CategoryDTO>(createdCategory));
        }

        [HttpPut("{Id}")]
        public async Task<IActionResult> UpdateCategory(int Id, CategoryForUpdateDTO categoryForUpdate)
        {
            var category = await categoryRepository.GetCategoryAsync(Id);
            if (category is null)
            {
                return NotFound();
            }

            var categoryUpdated = mapper.Map(categoryForUpdate, category);

            if (await categoryRepository.CategoryExistsAsync(category))
            {

                return BadRequest(
                problemDetailsFactory.CreateProblemDetails(HttpContext,
                    statusCode: 400,
                    detail: $"""Provided category "{categoryUpdated.Name}" exists in database."""));
            }
            await categoryRepository.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("{Id}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> DeleteCategoryAsync(int Id)
        {
            var category = await categoryRepository.GetCategoryAsync(Id);
            if (category is null)
            {
                return NotFound();
            }
            categoryRepository.DeleteCategory(category);
            await categoryRepository.SaveChangesAsync();
           
            return NoContent();
        }
    }
}