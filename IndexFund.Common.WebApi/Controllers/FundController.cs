using AutoMapper;
using IndexFund.Common.WebApi.Entities;
using IndexFund.Common.WebApi.Helpers;
using IndexFund.Common.WebApi.Models;
using IndexFund.Common.WebApi.ResourceParameters;
using IndexFund.Common.WebApi.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using System.Text.Json;

namespace IndexFund.Common.WebApi.Controllers
{
    [Route("api/fund")]
    [ApiController]
    public class FundController : ControllerBase
    {
        private readonly IMapper mapper;
        private readonly IFundRepository fundRepository;
        private readonly ProblemDetailsFactory problemDetailsFactory;

        public FundController(IMapper mapper, IFundRepository fundRepository, ProblemDetailsFactory problemDetailsFactory)
        {
            this.mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            this.fundRepository = fundRepository ?? throw new ArgumentNullException(nameof(fundRepository));
            this.problemDetailsFactory = problemDetailsFactory ?? throw new ArgumentNullException(nameof(problemDetailsFactory));
        }

        [HttpGet(Name = "GetFunds")]
        public async Task<ActionResult<IEnumerable<FundDTO>>> GetFunds([FromQuery] FundResourceParameters fundResource)
        {
            var funds = await fundRepository.GetFundsAsync(fundResource);
            var previousLink = funds.HasPrevious ? CreateFundsResourceUri(fundResource, ResourceUriType.PreviousPage) : null;
            var nextLink = funds.HasNext ? CreateFundsResourceUri(fundResource, ResourceUriType.NextPage) : null;
            var currentLink = CreateFundsResourceUri(fundResource, ResourceUriType.Current);
            var paginationMetadata = new PaginationMetadata(funds.TotalCount, funds.PageSize, funds.CurrentPage, previousLink, nextLink, currentLink);

            Response.Headers.Add("X-Pagination", JsonSerializer.Serialize(paginationMetadata));
            
            return base.Ok(mapper.Map<IEnumerable<FundDTO>>(funds));
        }

        [HttpGet("{fundId}", Name = "GetFund")]
        public async Task<ActionResult<FundDTO>> Getfund(int fundId)
        {
            return Ok(mapper.Map<FundDTO>(await fundRepository.GetFundAsync(fundId)));
        }

        [HttpPost(Name = "CreateFund")]
        public async Task<ActionResult<Fund>> CreateFundAsync(FundForCreationDTO fundForCreationDTO)
        {
            var newFund = mapper.Map<Fund>(fundForCreationDTO);
            await fundRepository.AddFundAsync(newFund);
            await fundRepository.SaveAsync();

            return CreatedAtRoute("GetFund", new { fundId = newFund.Id }, newFund);
        }

        [HttpPut("{fundId}", Name = "UpdateFund")]
        public async Task<ActionResult<Fund>> UpdateFundAsync(int fundId, FundForUpdateDTO fundForUpdateDTO)
        {
            if (fundForUpdateDTO is null)
            {
                return NotFound();
            }
            var fund = await fundRepository.GetFundAsync(fundId);
            
            if (fund == null)
            {
                return NotFound();
            }
            
            mapper.Map(fundForUpdateDTO, fund);
            
            if (!await fundRepository.CheckFundNamesUniquenessAsync(fund))
            {
                return BadRequest(problemDetailsFactory.CreateProblemDetails(HttpContext,
                    statusCode: 400,
                    detail: "Provided fund names exists in database."));
            }
            await fundRepository.SaveAsync();
            
            return NoContent();
        }

        private string? CreateFundsResourceUri(FundResourceParameters fundResourceParameters, ResourceUriType type)
        {
            switch (type)
            {
                case ResourceUriType.PreviousPage:
                    return Url.Link("GetFunds",
                        new
                        {
                            pageNumber = fundResourceParameters.PageNumber - 1,
                            pageSize = fundResourceParameters.PageSize,
                            categoryName = fundResourceParameters.CategoryName,
                            searchQuery = fundResourceParameters.SearchQuery
                        });
                case ResourceUriType.NextPage:
                    return Url.Link("GetFunds",
                        new
                        {
                            pageNumber = fundResourceParameters.PageNumber + 1,
                            pageSize = fundResourceParameters.PageSize,
                            categoryName = fundResourceParameters.CategoryName,
                            searchQuery = fundResourceParameters.SearchQuery
                        });
                case ResourceUriType.Current:
                default:
                    return Url.Link("GetFunds",
                        new
                        {
                            pageNumber = fundResourceParameters.PageNumber,
                            pageSize = fundResourceParameters.PageSize,
                            categoryName = fundResourceParameters.CategoryName,
                            searchQuery = fundResourceParameters.SearchQuery
                        });
            }
        }
    }
}
