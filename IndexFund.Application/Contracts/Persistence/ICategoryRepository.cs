namespace IndexFund.Application.Contracts.Persistence
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<Category>> GetCategoriesAsync();
        Task<Category?> GetCategoryAsync(int cateogryId);
        Task<bool> CategoryExistsAsync(Category category);
        Task CreateCategoryAsync(Category categoryToCreate);
        void DeleteCategory(Category categoryToCreate);
        Task<bool> SaveChangesAsync();
    }
}