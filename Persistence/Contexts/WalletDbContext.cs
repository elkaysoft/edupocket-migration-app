using Domain.Entities.Wallet;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Contexts
{
    public class WalletDbContext: DbContext
    {
        public WalletDbContext(DbContextOptions<WalletDbContext> options)
            :base(options) 
        {            
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly(), p => p.Namespace == "Persistence.Configurations.Wallets");

            foreach (var entityType in modelBuilder.Model.GetEntityTypes())
            {
                var parameter = Expression.Parameter(entityType.ClrType, "p");
                var deletedCheck = Expression.Lambda(Expression.Equal(Expression.Property(parameter, "IsDeleted"), Expression.Constant(false)), parameter);
                modelBuilder.Entity(entityType.ClrType).HasQueryFilter(deletedCheck);
            }

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Profile> Profiles { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Wallet> Wallets { get; set; }
        public DbSet<WalletBalanceHistory> WalletBalanceHistories { get; set; }
    }
}
