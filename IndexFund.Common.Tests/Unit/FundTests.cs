using IndexFund.Common.WebApi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexFund.Common.Tests.Unit
{
    public class FundTests
    {
        [Fact]
        internal void FundConstructor_ConstructFund_isActiveMustBeFalse()
        {
            var fund = new Fund
            {
                Id = 1,
                Name = "Index Fund Polish stocks",
                ShortName = "Index Polish stocks",
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
            };

            Assert.False(fund.IsActive);
        }
    }
}
