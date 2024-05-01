using IndexFund.Domain.Entities;

namespace IndexFund.Application.Contracts.Persistence
{
    public interface ICategoryRepository : IAsyncRepository<Category>
    {
    }
}