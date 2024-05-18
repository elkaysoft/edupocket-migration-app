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
    public class RefreshTokenHistoryConfiguration : IEntityTypeConfiguration<RefreshTokenHistory>
    {
        public void Configure(EntityTypeBuilder<RefreshTokenHistory> builder)
        {
            builder.ToTable("RefreshTokenHistories", t => t.HasComment("The table stores refresh token information"));

            builder.HasKey(t => t.Id);
            builder.Property(p => p.RefreshToken).IsRequired().HasMaxLength(500);

            builder.Property(t => t.CreatedBy).HasMaxLength(50).IsRequired();
            builder.Property(t => t.DateCreated).IsRequired();
            builder.Property(t => t.CreatedByIp).HasMaxLength(50);

            builder.Property(t => t.UpdatedBy).HasMaxLength(50);
            builder.Property(t => t.ModifiedByIp).HasMaxLength(50);
        }
    }
}
