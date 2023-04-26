
using IndexFund.Common.WebApi.Entities;
using IndexFund.Common.WebApi.Helpers;
using IndexFund.Common.WebApi.Models;
using IndexFund.Common.WebApi.ResourceParameters;

namespace IndexFund.Common.WebApi.Services
{
    public interface IFundRepository
    {
        Task AddFundAsync(Fund fundToAdd);
        Task<bool> CheckFundNamesUniquenessAsync(Fund fundToUpdate);
        Task<Fund?> GetFundAsync(int fundId);
        Task<PagedList<Fund?>> GetFundsAsync(FundResourceParameters fundResourceParameters);
        Task<bool> SaveAsync();
    }
}