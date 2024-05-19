using IndexFund.Application.ResourceParameters;
using IndexFund.Domain.Entities;

namespace IndexFund.Application.Contracts.Persistence
{
    public interface IFundRepository : IAsyncRepository<Fund>
    {
        Task<bool> CheckFundNamesUniquenessAsync(Fund fundToUpdate);

        Task<List<Fund?>> GetFundsAsync(FundResourceParameters fundResourceParameters);
    }
}