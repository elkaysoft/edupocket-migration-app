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
    public class ProfileConfiguration : IEntityTypeConfiguration<Profile>
    {
        public void Configure(EntityTypeBuilder<Profile> builder)
        {
            builder.ToTable("Profile", t => t.HasComment("The table stores profile information"));

            builder.HasKey(t => t.Id);
            builder.Property(t => t.FirstName).IsRequired().HasMaxLength(50);
            builder.Property(t => t.LastName).IsRequired().HasMaxLength(50);
            builder.Property(t => t.OtherName).HasMaxLength(50);
            builder.Property(t => t.UserType).HasMaxLength(20);
            builder.Property(t => t.CheckSum).IsRequired().HasMaxLength(500);
            builder.Property(t => t.ProfileImage).HasMaxLength(1500);
            builder.Property(t => t.EmailAddress).IsRequired().HasMaxLength(150);
            builder.Property(t => t.MobileNumber).IsRequired().HasMaxLength(50);

            builder.Property(t => t.UserType).HasConversion<string>().IsRequired().HasMaxLength(10);
            builder.Property(t => t.TransactionPinHash).IsRequired().HasMaxLength(200);

            builder.Property(t => t.CreatedBy).HasMaxLength(50).IsRequired();
            builder.Property(t => t.DateCreated).IsRequired();
            builder.Property(t => t.CreatedByIp).HasMaxLength(50);

            builder.Property(t => t.UpdatedBy).HasMaxLength(50);
            builder.Property(t => t.ModifiedByIp).HasMaxLength(50);

            builder.OwnsOne(o => o.Beneficiary).Property(t => t.NickName).HasColumnName("BeneficiaryNickName").HasMaxLength(50);
            builder.OwnsOne(o => o.Beneficiary).Property(t => t.Name).HasColumnName("BeneficiaryAccountName").HasMaxLength(100);
            builder.OwnsOne(o => o.Beneficiary).Property(t => t.WalletNumber).HasColumnName("BeneficiaryWalletNumber").HasMaxLength(15);
        }
    }
}
