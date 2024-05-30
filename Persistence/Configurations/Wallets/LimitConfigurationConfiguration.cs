using Domain.Entities.Wallets;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Configurations.Wallets
{
    public class LimitConfigurationConfiguration : IEntityTypeConfiguration<LimitConfiguration>
    {
        public void Configure(EntityTypeBuilder<LimitConfiguration> builder)
        {

            builder.ToTable("LimitConfiguration", t => t.HasComment("The table stores limit configuration records"));

            builder.HasKey(t => t.Id);
            builder.Property(t => t.Name).IsRequired().HasMaxLength(50);
            builder.Property(t => t.Description).IsRequired().HasMaxLength(150);
            builder.Property(t => t.UserType).IsRequired().HasMaxLength(15).HasConversion<string>();
            builder.Property(t => t.MaxBalanceLimit).HasPrecision(18, 2);
            builder.Property(t => t.SingleLimit).HasPrecision(18, 2);
            builder.Property(t => t.CumulativeLimit).HasPrecision(18, 2);


            builder.Property(t => t.CreatedBy).HasMaxLength(50).IsRequired();
            builder.Property(t => t.DateCreated).IsRequired();
            builder.Property(t => t.CreatedByIp).HasMaxLength(50);

            builder.Property(t => t.UpdatedBy).HasMaxLength(50);
            builder.Property(t => t.ModifiedByIp).HasMaxLength(50);
        }
    }
}
