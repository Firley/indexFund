using IndexFund.Common.WebApi.Entities;
using Microsoft.EntityFrameworkCore;

namespace IndexFund.Common.WebApi.Services
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly FundDbContext fundDbContext;

        public CategoryRepository(FundDbContext fundDbContext)
        {
            this.fundDbContext = fundDbContext;
        }

        public async Task<IEnumerable<Category>> GetCategoriesAsync()
        {
            return await fundDbContext.Categories.ToListAsync();
        }

        public async Task<Category?> GetCategoryAsync(int categoryId)
        {
            return await fundDbContext.Categories.FirstOrDefaultAsync(c => c.Id == categoryId);
        }

        public async Task CreateCategoryAsync(Category categoryToCreate)
        {
            await fundDbContext.Categories.AddAsync(categoryToCreate);
        }

        public async Task<bool> SaveChangesAsync()
        {
            return (await fundDbContext.SaveChangesAsync() >= 0);
        }

        public async Task<bool> CategoryExistsAsync(Category category)
        {
            return await fundDbContext.Categories.AnyAsync(c => c.Name == category.Name);
        }

        public void DeleteCategory(Category categoryToDelete)
        {

            fundDbContext.Categories.Remove(categoryToDelete);
        }
    }
}
