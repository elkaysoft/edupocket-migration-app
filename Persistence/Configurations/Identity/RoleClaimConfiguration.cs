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
    public class RoleClaimConfiguration : IEntityTypeConfiguration<RoleClaims>
    {
        public void Configure(EntityTypeBuilder<RoleClaims> builder)
        {
            builder.ToTable("RoleClaims", t => t.HasComment("The table stores role claims information"));
            builder.HasKey(t => t.Id);
            builder.Property(t => t.ClaimValue).IsRequired().HasMaxLength(128);

            builder.Property(t => t.CreatedBy).HasMaxLength(50).IsRequired();
            builder.Property(t => t.DateCreated).IsRequired();
            builder.Property(t => t.CreatedByIp).HasMaxLength(50);

            builder.Property(t => t.UpdatedBy).HasMaxLength(50);
            builder.Property(t => t.ModifiedByIp).HasMaxLength(50);
        }
    }
}
