using IndexFund.Common.WebApi.Entities;
using IndexFund.Common.WebApi.Helpers;
using IndexFund.Common.WebApi.ResourceParameters;
using IndexFund.Common.WebApi.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexFund.Common.Tests.Unit.FundTestDataRepository
{
    internal class FundTestDataRepository : IFundRepository
    {

        public List<Fund> funds = new List<Fund>()
        {
            new Fund()
            {
                Id = 1,
                Name = "Index Fund Polish stocks " ,
                ShortName = "Index Polish stocks " ,
                Benchmark = "Vanguard S&P 500 ETF",
                RiskLevel = 3,
                FirstMinimalPayment = 500,
                MinimalPayment = 100,
                ManagementFee = 0.5M,
                HandlingFee = 1,
                UnitPrice = 100,
                InternalCurrency = "PLN",
                ExternalCurrency = "USD",
                PayoutCurrency = "PLN",
                FundStartDate = DateTime.Now.AddDays(-999),
                CategoryId = 1
            },
            new Fund()
            {
                Id = 2,
                Name = "Index Fund Foregin stocks" ,
                ShortName = "Index Foregin stocks" ,
                Benchmark = "Vanguard S&P 500 ETF",
                RiskLevel = 3,
                FirstMinimalPayment = 500,
                MinimalPayment = 100,
                ManagementFee = 1.5M,
                HandlingFee = 1,
                UnitPrice = 100,
                InternalCurrency = "PLN",
                ExternalCurrency = "USD",
                PayoutCurrency = "PLN",
                FundStartDate = DateTime.Now.AddDays(-999),
                CategoryId = 2
            }
        };

        public Task AddFundAsync(Fund fundToAdd)
        {
            throw new NotImplementedException();
        }

        public Task<Fund?> GetFundAsync(int fundId)
        {
            return Task.FromResult(funds.FirstOrDefault(f => f.Id == fundId));
        }

        public Task<PagedList<Fund?>> GetFundsAsync(FundResourceParameters fundResourceParameters)
        {
            throw new NotImplementedException();
        }

        public Task<bool> SaveAsync()
        {
            return Task.FromResult(true);
        }
    }
}
