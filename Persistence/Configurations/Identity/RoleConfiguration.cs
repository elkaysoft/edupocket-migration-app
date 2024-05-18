using Domain.Entities.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Configurations.Identity
{
    public class RoleConfiguration : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.ToTable("Roles", t => t.HasComment("The table stores roles information"));

            builder.HasKey(t => t.Id);
            builder.Property(t => t.Name).HasMaxLength(128).IsRequired();
            builder.Property(t => t.Description).HasMaxLength(508).IsRequired();
            builder.Property(t => t.Status).HasConversion<string>().HasMaxLength(15).IsRequired();

            builder.Property(t => t.CreatedBy).HasMaxLength(50).IsRequired();
            builder.Property(t => t.DateCreated).IsRequired();
            builder.Property(t => t.CreatedByIp).HasMaxLength(50);

            builder.Property(t => t.UpdatedBy).HasMaxLength(50);
            builder.Property(t => t.ModifiedByIp).HasMaxLength(50);
        }
    }
}
