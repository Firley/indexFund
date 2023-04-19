using AutoMapper;
using IndexFund.Common.WebApi.Entities;
using IndexFund.Common.WebApi.Helpers;
using IndexFund.Common.WebApi.Models;
using IndexFund.Common.WebApi.ResourceParameters;
using IndexFund.Common.WebApi.Services;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace IndexFund.Common.WebApi.Controllers
{
    [Route("api/fund")]
    [ApiController]
    public class FundController : ControllerBase
    {
        private readonly IMapper mapper;
        private readonly IFundRepository fundRepository;

        public FundController(IMapper mapper, IFundRepository fundRepository)
        {
            this.mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            this.fundRepository = fundRepository ?? throw new ArgumentNullException(nameof(fundRepository));
        }

        [HttpGet(Name = "GetFunds")]
        public async Task<ActionResult<IEnumerable<Models.FundDTO>>> GetFunds([FromQuery] FundResourceParameters fundResource)
        {
            var funds = await fundRepository.GetFundsAsync(fundResource);
            var previousLink = funds.HasPrevious ? CreateFundsResourceUri(fundResource, ResourceUriType.PreviousPage) : null;
            var nextLink = funds.HasNext ? CreateFundsResourceUri(fundResource, ResourceUriType.NextPage) : null;
            var currentLink = CreateFundsResourceUri(fundResource, ResourceUriType.Current);
            var paginationMetadata = new PaginationMetadata(funds.TotalCount,funds.PageSize,funds.CurrentPage,previousLink,nextLink, currentLink);

            Response.Headers.Add("X-Pagination", JsonSerializer.Serialize(paginationMetadata));
            return base.Ok(mapper.Map<IEnumerable<Models.FundDTO>>(funds));
        }

        [HttpGet("{fundId}", Name = "GetFund")]
        public async Task<ActionResult<Entities.Fund>> Getfund(int fundId)
        {
            return Ok(await fundRepository.GetFundAsync(fundId));
        }



        [HttpPost(Name = "CreateFund")]
        public async Task<ActionResult<Entities.Fund>> CreateFundAsync(FundForCreationDTO fundForCreationDTO)
        {
            var newFund = mapper.Map<Entities.Fund>(fundForCreationDTO);
            await fundRepository.AddFundAsync(newFund);
            await fundRepository.SaveAsync();

            return CreatedAtRoute("GetFund", new { fundId = newFund.Id }, newFund);
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
