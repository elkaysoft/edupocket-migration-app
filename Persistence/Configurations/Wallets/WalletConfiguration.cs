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
    public class WalletConfiguration : IEntityTypeConfiguration<Wallet>
    {
        public void Configure(EntityTypeBuilder<Wallet> builder)
        {
            builder.ToTable("Wallet", t => t.HasComment("The table stores wallet information"));

            builder.HasKey(t => t.Id);
            builder.Property(t => t.WalletNumber).IsRequired().HasMaxLength(10);
            builder.Property(t => t.Status).HasConversion<string>().IsRequired().HasMaxLength(10);
            builder.Property(t => t.Balance).HasPrecision(18, 4).IsRequired();
            builder.Property(t => t.IsPndActive).HasDefaultValue(false);
            builder.Property(t => t.CheckSum).HasMaxLength(1000).IsRequired();
            builder.Property(t => t.ProfileId).IsRequired().HasMaxLength(50);
            builder.Property(t => t.WalletSchemeId).IsRequired().HasMaxLength(50);


            builder.Property(t => t.CreatedBy).HasMaxLength(50).IsRequired();
            builder.Property(t => t.DateCreated).IsRequired();
            builder.Property(t => t.CreatedByIp).HasMaxLength(50);

            builder.Property(t => t.UpdatedBy).HasMaxLength(50);
            builder.Property(t => t.ModifiedByIp).HasMaxLength(50);
        }
    }
}
