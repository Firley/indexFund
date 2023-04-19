namespace IndexFund.Common.DatabaseContext
{
    public class FundDbContext : DbContext
    {
        public FundDbContext(DbContextOptions<FundDbContext> options) : base(options)
        {
        }

        public DbSet<Fund> Funds { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<FundUser> Users { get; set; }
        public DbSet<Role> Roles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

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
                new Role {Id = 3, Name = "Admin"},
            };
            modelBuilder.Entity<Role>().HasData(roles);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
         => optionsBuilder
        .LogTo(Console.WriteLine)
        .EnableSensitiveDataLogging();
    }


}
