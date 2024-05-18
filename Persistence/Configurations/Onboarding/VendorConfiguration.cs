using Domain.Entities.Onboarding;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Configurations.Onboarding
{
    public class VendorConfiguration : IEntityTypeConfiguration<Vendor>
    {
        public void Configure(EntityTypeBuilder<Vendor> builder)
        {
            builder.ToTable("Vendors", t => t.HasComment("The table vendors information"));

            builder.HasKey(t => t.Id);
            builder.Property(t => t.FirstName).IsRequired().HasMaxLength(50);
            builder.Property(t => t.LastName).IsRequired().HasMaxLength(50);
            builder.Property(t => t.BusinessName).IsRequired().HasMaxLength(150);
            builder.Property(t => t.BusinessType).IsRequired().HasMaxLength(50);
            builder.Property(t => t.EmailAddress).IsRequired().HasMaxLength(150);
            builder.Property(t => t.PhoneNumber).IsRequired().HasMaxLength(50);            
            builder.Property(t => t.Address).HasMaxLength(500);
            builder.Property(t => t.SettlementAccount).HasMaxLength(50);
            builder.Property(t => t.Status).HasMaxLength(20).IsRequired().HasConversion<string>();
            builder.Property(t => t.CheckSum).IsRequired().HasMaxLength(500);
            builder.Property(t => t.OnboardingStatus).HasMaxLength(20).IsRequired().HasConversion<string>();
            builder.Property(t => t.Institution).IsRequired().HasMaxLength(150);
            builder.Property(t => t.WalletNumber).IsRequired().HasMaxLength(10);



            builder.Property(t => t.CreatedBy).HasMaxLength(50).IsRequired();
            builder.Property(t => t.DateCreated).IsRequired();
            builder.Property(t => t.CreatedByIp).HasMaxLength(50);

            builder.Property(t => t.UpdatedBy).HasMaxLength(50);
            builder.Property(t => t.ModifiedByIp).HasMaxLength(50);
        }
    }
}
