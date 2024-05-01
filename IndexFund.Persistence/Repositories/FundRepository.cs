using IndexFund.Application.Contracts.Persistence;
using IndexFund.Application.ResourceParameters;
using IndexFund.Common.WebApi.ResourceParameters;
using IndexFund.Domain.Entities;
using IndexFund.Persistence.Helpers;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace IndexFund.Persistence.Repositories
{
    public class FundRepository : BaseRepository<Fund>, IFundRepository
    {
        public FundRepository(FundDbContext fundDbContext) : base(fundDbContext) 
        { 
        }

        public async Task<bool> CheckFundNamesUniquenessAsync(Fund fundToUpdate)
        {
            if (await dbContext.Funds.Where(f => f.Id != fundToUpdate.Id)
                .AnyAsync(f => f.Name == fundToUpdate.Name || f.ShortName == fundToUpdate.ShortName))
            {
                return false;
            }

            return true;
        }

        public Task<List<Fund?>> GetFundsAsync(FundResourceParameters fundResource)
        {
            var collection = dbContext.Funds
                           .Where(f => f.IsActive == true)
                           .Include(f => f.Category) as IQueryable<Entities.Fund>;

            if (!string.IsNullOrWhiteSpace(fundResource.CategoryName))
            {
                var filterCategory = fundResource.CategoryName.Trim();
                collection = collection.Where(f => f.Category.Name == fundResource.CategoryName);
            }

            if (!string.IsNullOrWhiteSpace(fundResource.SearchQuery))
            {
                var searchQuery = fundResource.SearchQuery.Trim();
                collection = collection
                    .Where(c => c.Name.Contains(fundResource.SearchQuery) || c.ShortName.Contains(fundResource.SearchQuery));
            }

            if (!string.IsNullOrEmpty(fundResource.OrderBy))
            {
                var columnsSelectors = new Dictionary<string, Expression<Func<Fund, object>>>
                {
                    { nameof(Fund.Id).ToUpper(), f => f.Id },
                    { nameof(Fund.Name).ToUpper(), f => f.Name },
                    { nameof(Fund.ShortName).ToUpper(), f => f.ShortName },
                    { nameof(Fund.Category).ToUpper(), f => f.Category.Name },
                };
                var selectedColumn = columnsSelectors[fundResource.OrderBy];

                collection = fundResource.SortDirection == SortDirection.ASC
                    ? collection.OrderBy(selectedColumn)
                    : collection.OrderByDescending(selectedColumn);
            }

            var totalItemCount = await collection.CountAsync();

            return await PagedList<Fund?>.CreateAsync(collection, fundResource.PageNumber, fundResource.PageSize);
        }
    }
}