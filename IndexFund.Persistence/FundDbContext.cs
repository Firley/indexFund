using IndexFund.Common.WebApi.Entities;
using IndexFund.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace IndexFund.Common.WebApi
{
    public class FundDbContext : DbContext
    {
        public FundDbContext(DbContextOptions<FundDbContext> options) : base(options) {}

        public DbSet<Fund> Funds { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<Role> Roles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

#if DEBUG
            Category[] categories = new Category[] {
                new Category {Id = 1, Name = "Polish stocks" },
                new Category {Id = 2, Name = "Foreign stocks" },
                new Category {Id = 3, Name = "Polish bonds" },
                new Category {Id = 4, Name = "Foreign bonds"},
                new Category {Id = 5, Name = "Mixed funds"},
                new Category {Id = 6, Name = "Commodities"}
            };

            modelBuilder.Entity<Category>().HasData(categories);

            Role[] roles = new Role[]
            {
                new Role {Id = 1,Name = "Normal"},
                new Role {Id = 2,Name = "Moderator"},
                new Role {Id = 3,Name = "Admin"},
            };
            modelBuilder.Entity<Role>().HasData(roles);

            List<Fund>funds = new List<Fund>()
            {
                new Fund {Id =1, Name="Index Fund S&P500 Vanguard QQQ USD",ShortName="S&P500 Vanguard QQQ USD",Benchmark="Vanguard S&P 500 ETF",RiskLevel=3,FirstMinimalPayment=500, MinimalPayment=100, ManagementFee=0.5M, HandlingFee=1,UnitPrice=100,IsActive=true,InternalCurrency="PLN",ExternalCurrency="USD",PayoutCurrency="PLN", FundStartDate=DateTime.Now.AddDays(-30), CategoryId=2},
                new Fund {Id =2, Name="Index Fund SSPDR S&P 500 ETF Trust",ShortName="SSPDR S&P 500 ETF Trust",Benchmark="SSPDR S&P 500 ETF Trust",RiskLevel=3,FirstMinimalPayment=100, MinimalPayment=100, ManagementFee=0.7M, HandlingFee=1,UnitPrice=200,IsActive=true,InternalCurrency="PLN",ExternalCurrency="USD",PayoutCurrency="PLN", FundStartDate=DateTime.Now.AddDays(-30), CategoryId=2},
                new Fund {Id =3, Name="Index Fund iShares Core S&P 500 ETF",ShortName="iShares Core S&P 500 ETF",Benchmark="iShares Core S&P 500 ETF USD",RiskLevel=5,FirstMinimalPayment=100, MinimalPayment=100, ManagementFee=.55M, HandlingFee=1,UnitPrice=100,IsActive=true,InternalCurrency="PLN",ExternalCurrency="USD",PayoutCurrency="PLN", FundStartDate=DateTime.Now.AddDays(-330), CategoryId=2},
                new Fund {Id =4, Name="Index Fund iShares Core S&P 500 ETF QQQ USD",ShortName="iShares Core S&P 500 ETF QQQ",Benchmark="iShares Core S&P 500 ETF USD",RiskLevel=5,FirstMinimalPayment=500, MinimalPayment=50, ManagementFee=.75M, HandlingFee=1,UnitPrice=100,IsActive=true,InternalCurrency="PLN",ExternalCurrency="USD",PayoutCurrency="PLN", FundStartDate=DateTime.Now.AddDays(-100), CategoryId=2},
                new Fund {Id =5, Name="Index Fund Vanguard S&P 500 ETF (VOO)",ShortName="S&P 500 ETF (VOO)",Benchmark = "Vanguard S&P 500 ETF (VOO)", RiskLevel=2,FirstMinimalPayment=100, MinimalPayment=100, ManagementFee=1, HandlingFee=1,UnitPrice=100,IsActive=false,InternalCurrency="PLN",ExternalCurrency="PLN",PayoutCurrency="PLN", FundStartDate=DateTime.Now.AddDays(-100), CategoryId=2},
                new Fund {Id =6, Name="Index Fund U.S. Treasury Bond EF",ShortName="U.S. Treasury Bond",Benchmark = "iShares U.S. Treasury Bond ETF", RiskLevel=1,FirstMinimalPayment=500, MinimalPayment=100, ManagementFee=0.2M, HandlingFee=0.1M,UnitPrice=100,IsActive=false,InternalCurrency="USD",ExternalCurrency="USD",PayoutCurrency="USD", FundStartDate=DateTime.Now.AddDays(-30), CategoryId=4},
                new Fund {Id =7, Name="Index Fund World Treasury Bond ETF",ShortName="World Treasury Bond",Benchmark = "iShares World Treasury Bond ETF", RiskLevel=1,FirstMinimalPayment=500, MinimalPayment=100, ManagementFee=0.2M, HandlingFee=0.15M,UnitPrice=100,IsActive=false,InternalCurrency="USD",ExternalCurrency="USD",PayoutCurrency="USD", FundStartDate=DateTime.Now.AddDays(-30), CategoryId=4},
                new Fund {Id =8, Name="Index Fund Europe Treasury Bond ETF",ShortName="Europe Treasury Bond",Benchmark = "iShares Europe Treasury Bond ETF", RiskLevel=1,FirstMinimalPayment=500, MinimalPayment=100, ManagementFee=0.2M, HandlingFee=0.15M,UnitPrice=100,IsActive=false,InternalCurrency="PLN",ExternalCurrency="EUR",PayoutCurrency="EUR", FundStartDate=DateTime.Now.AddDays(-837), CategoryId=4},
                new Fund {Id =9, Name="Index Fund UE Treasury Bond ETF",ShortName="UE Treasury Bond",Benchmark = "iShares UE Treasury Bond ETF", RiskLevel=1,FirstMinimalPayment=500, MinimalPayment=100, ManagementFee=0.2M, HandlingFee=0.10M,UnitPrice=100,IsActive=false,InternalCurrency="USD",ExternalCurrency="USD",PayoutCurrency="USD", FundStartDate=DateTime.Now.AddDays(-30), CategoryId=4},
                new Fund {Id =10, Name="Index Fund UE Corporate Bond ETF",ShortName="UECorporate Bond",Benchmark = "iShares Corporate Treasury Bond ETF", RiskLevel=2,FirstMinimalPayment=500, MinimalPayment=100, ManagementFee=0.2M, HandlingFee=0.10M,UnitPrice=100,IsActive=false,InternalCurrency="USD",ExternalCurrency="USD",PayoutCurrency="USD", FundStartDate=DateTime.Now.AddDays(-367), CategoryId=4},
                new Fund {Id =11, Name="Index Fund Schwab U.S. Dividend Equity ETF",ShortName="Dividend Equity ETF",Benchmark = "Schwab U.S. Dividend Equity ETF", RiskLevel=1,FirstMinimalPayment=500, MinimalPayment=100, ManagementFee=0.5M, HandlingFee=0.5M,UnitPrice=100,IsActive=false,InternalCurrency="PLN",ExternalCurrency="PLN",PayoutCurrency="PLN", FundStartDate=DateTime.Now.AddDays(-690), CategoryId=2},
                new Fund {Id =12, Name="Index Fund Invesco Optimum Yield Diversified Commodity Strategy",ShortName="Optimum Yield Diversified Commodity Strategy",Benchmark = "Optimum Yield Diversified Commodity Strategy", RiskLevel=4,FirstMinimalPayment=500, MinimalPayment=100, ManagementFee=1, HandlingFee=1,UnitPrice=100,IsActive=false,InternalCurrency="PLN",ExternalCurrency="PLN",PayoutCurrency="PLN", FundStartDate=DateTime.Now.AddDays(-39), CategoryId=6},
                new Fund {Id =13, Name="Index Fund SPDR SWIG100 ETF Trust",ShortName="SPDR SWIG100",Benchmark = "SPDR SWIG100 ETF Trust", RiskLevel=1,FirstMinimalPayment=100, MinimalPayment=100, ManagementFee=1, HandlingFee=1,UnitPrice=100,IsActive=false,InternalCurrency="PLN",ExternalCurrency="PLN",PayoutCurrency="PLN", FundStartDate=DateTime.Now.AddDays(-530), CategoryId=1},
                new Fund {Id =14, Name="Index Fund Schwab POL Dividend Equity",ShortName="Schwab POL Dividend Equity",Benchmark = "Schwab POL Dividend Equity", RiskLevel=1,FirstMinimalPayment=100, MinimalPayment=100, ManagementFee=1, HandlingFee=1,UnitPrice=100,IsActive=false,InternalCurrency="PLN",ExternalCurrency="PLN",PayoutCurrency="PLN", FundStartDate=DateTime.Now.AddDays(-730), CategoryId=1},
                new Fund {Id =15, Name="Index Fund Treasury Polish bond",ShortName="Treasury Polish bond",Benchmark = "iShares Treasury Polish bond", RiskLevel=1,FirstMinimalPayment=100, MinimalPayment=100, ManagementFee=1, HandlingFee=1,UnitPrice=100,IsActive=false,InternalCurrency="PLN",ExternalCurrency="PLN",PayoutCurrency="PLN", FundStartDate=DateTime.Now.AddDays(-530), CategoryId=3},
                new Fund {Id =16, Name="Index Fund Mixed funds Total Return",ShortName="iShares Mixed funds TR",Benchmark = "iShares Mixed funds", RiskLevel=1,FirstMinimalPayment=100, MinimalPayment=100, ManagementFee=1, HandlingFee=1,UnitPrice=100,IsActive=false,InternalCurrency="PLN",ExternalCurrency="PLN",PayoutCurrency="PLN", FundStartDate=DateTime.Now.AddDays(-330), CategoryId=5},
                new Fund {Id =17, Name="Index Fund Polish stocks Test",ShortName="Polish stocks iShares",Benchmark = "iShares", RiskLevel=1,FirstMinimalPayment=100, MinimalPayment=100, ManagementFee=1, HandlingFee=1,UnitPrice=100,IsActive=false,InternalCurrency="PLN",ExternalCurrency="PLN",PayoutCurrency="PLN", FundStartDate=DateTime.Now.AddDays(-600), CategoryId=1},
                new Fund {Id =18, Name="Index Fund World Commodities",ShortName="World Commodities",Benchmark = "iShares World Commodities", RiskLevel=1,FirstMinimalPayment=100, MinimalPayment=100, ManagementFee=1, HandlingFee=1,UnitPrice=100,IsActive=false,InternalCurrency="PLN",ExternalCurrency="PLN",PayoutCurrency="PLN", FundStartDate=DateTime.Now.AddDays(-300), CategoryId=6},
            };
            for (int i = 0; i < 10; i++)
            {
                funds.Add(new Fund
                {
                    Id = funds.Max(f=> f.Id)+1,
                    Name = "Index Fund Polish stocks " + i,
                    ShortName = "Index Polish stocks " + i,
                    Benchmark = "Vanguard S&P 500 ETF" + i,
                    RiskLevel = 3,
                    FirstMinimalPayment = 500,
                    MinimalPayment = 100,
                    ManagementFee = 0.5M,
                    HandlingFee = 1,
                    UnitPrice = 100,
                    IsActive = true,
                    InternalCurrency = "PLN",
                    ExternalCurrency = "USD",
                    PayoutCurrency = "PLN",
                    FundStartDate = DateTime.Now.AddDays(-999+i),
                    CategoryId = 1
                }
                ); ;
            }
            for (int i = 0; i < 5; i++)
            {
                funds.Add(new Fund
                {
                    Id = funds.Max( f=> f.Id)+1,
                    Name = "Index Fund Mixed funds " + i,
                    ShortName = "Index Mixed funds " + i,
                    Benchmark = "Foreign bonds ETF" + i,
                    RiskLevel = 2,
                    FirstMinimalPayment = 100,
                    MinimalPayment = 100,
                    ManagementFee = 0.25M,
                    HandlingFee = 1,
                    UnitPrice = 100,
                    IsActive = true,
                    InternalCurrency = "PLN",
                    ExternalCurrency = "PLN",
                    PayoutCurrency = "PLN",
                    FundStartDate = DateTime.Now.AddDays(-350+i),
                    CategoryId = 5
                }
                ); ;
            }

            for (int i = 0; i < 3; i++)
            {
                funds.Add(new Fund
                {
                    Id = funds.Max(f=> f.Id)+1,
                    Name = "Index Fund Foreign bonds " + i,
                    ShortName = "Index Foreign bonds " + i,
                    Benchmark = "Foreign bonds ETF" + i,
                    RiskLevel = 2,
                    FirstMinimalPayment = 100,
                    MinimalPayment = 100,
                    ManagementFee = 0.1M,
                    HandlingFee = 1,
                    UnitPrice = 100,
                    IsActive = true,
                    InternalCurrency = "PLN",
                    ExternalCurrency = "PLN",
                    PayoutCurrency = "PLN",
                    FundStartDate = DateTime.Now.AddDays(-750 - i),
                    CategoryId = 4
                }
                ); ;
            }
            modelBuilder.Entity<Fund>().HasData(funds);
        }
#endif
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .LogTo(Console.WriteLine)
                .EnableSensitiveDataLogging();
        }
    }
}
