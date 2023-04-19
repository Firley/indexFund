
using IndexFund.Common.WebApi.Entities;
using IndexFund.Common.WebApi.Helpers;
using IndexFund.Common.WebApi.Models;
using IndexFund.Common.WebApi.ResourceParameters;

namespace IndexFund.Common.WebApi.Services
{
    public interface IFundRepository
    {
        Task AddFundAsync(Entities.Fund fundToAdd);
        Task<Entities.Fund> GetFundAsync(int fundId);
        Task<PagedList<Entities.Fund?>> GetFundsAsync(FundResourceParameters fundResourceParameters);
        Task<bool> SaveAsync();
    }
}