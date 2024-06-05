using Domain.Entities.Wallets;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using System.Reflection;

namespace Persistence.Contexts
{
    public class WalletsDbContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                string connectionString = ConfigurationHelper.GetConnectionString();
                optionsBuilder.UseSqlServer(connectionString);
            }
        }       
        


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly(), p => p.Namespace == "Persistence.Configurations.Wallets");

            //foreach (var entityType in modelBuilder.Model.GetEntityTypes())
            //{
            //    var parameter = Expression.Parameter(entityType.ClrType, "p");
            //    var deletedCheck = Expression.Lambda(Expression.Equal(Expression.Property(parameter, "IsDeleted"), Expression.Constant(false)), parameter);
            //    modelBuilder.Entity(entityType.ClrType).HasQueryFilter(deletedCheck);
            //}

            modelBuilder.Entity<Wallet>().ToTable("Wallets");
            modelBuilder.Entity<Transaction>().ToTable("Transactions");
            modelBuilder.Entity<WalletBalanceHistory>().ToTable("WalletBalanceHistories");
            modelBuilder.Entity<Profile>().ToTable("Profiles");
            modelBuilder.Entity<WalletScheme>().ToTable("WalletSchemes");
            modelBuilder.Entity<WalletSchemeAccount>().ToTable("WalletSchemeAccounts");
            modelBuilder.Entity<LimitConfiguration>().ToTable("LimitConfigurations");
            modelBuilder.Entity<WalletSchemeAccountTransaction>().ToTable("WalletSchemeAccountsTransactions");

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Profile> Profiles { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Wallet> Wallets { get; set; }
        public DbSet<WalletBalanceHistory> WalletBalanceHistories { get; set; }
        public DbSet<WalletScheme> WalletSchemes { get; set; }
        public DbSet<WalletSchemeAccount> WalletSchemeAccounts { get; set; }
        public DbSet<LimitConfiguration> LimitConfigurations { get; set; }
        public DbSet<WalletSchemeAccountTransaction> WalletSchemeAccountsTransactions { get; set; }
    }
}
