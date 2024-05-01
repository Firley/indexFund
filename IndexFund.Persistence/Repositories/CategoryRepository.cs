using IndexFund.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace IndexFund.Persistence.Repositories
{
    public class CategoryRepository : BaseRepository<Category>, Application.Contracts.Persistence.ICategoryRepository 
    {

        public CategoryRepository(FundDbContext fundDbContext) : base(fundDbContext)
        {
        }
     
    }
}
