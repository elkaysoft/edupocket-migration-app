using Domain.Entities.Identity;
using Domain.Entities.Onboarding;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using System.Reflection;

namespace Persistence.Contexts
{
    public class OnboardingDbContext: DbContext
    {
        public OnboardingDbContext(DbContextOptions<OnboardingDbContext> options)
            :base(options)
        {            
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly(), p => p.Namespace == "Persistence.Configurations.Onboarding");

            foreach (var entityType in modelBuilder.Model.GetEntityTypes())
            {
                var parameter = Expression.Parameter(entityType.ClrType, "p");
                var deletedCheck = Expression.Lambda(Expression.Equal(Expression.Property(parameter, "IsDeleted"), Expression.Constant(false)), parameter);
                modelBuilder.Entity(entityType.ClrType).HasQueryFilter(deletedCheck);
            }

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Student> Students { get; set; }    
        public DbSet<Vendor> Vendors { get; set; }
        public DbSet<BusinessTypes> BusinessTypes { get; set; }
    }
}
