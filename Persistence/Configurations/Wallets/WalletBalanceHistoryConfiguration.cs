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
    public class WalletBalanceHistoryConfiguration : IEntityTypeConfiguration<WalletBalanceHistory>
    {
        public void Configure(EntityTypeBuilder<WalletBalanceHistory> builder)
        {
            builder.ToTable("Wallet", t => t.HasComment("The table stores wallet balance history information"));

            builder.HasKey(t => t.Id);
            builder.Property(t => t.WalletId).IsRequired().HasMaxLength(50);
            builder.Property(t => t.CheckSum).IsRequired().HasMaxLength(500);
            builder.Property(t => t.OpeningBalance).IsRequired().HasPrecision(18, 2);
            builder.Property(t => t.ClosingBalance).IsRequired().HasPrecision(18, 2);


            builder.Property(t => t.CreatedBy).HasMaxLength(50).IsRequired();
            builder.Property(t => t.DateCreated).IsRequired();
            builder.Property(t => t.CreatedByIp).HasMaxLength(50);

            builder.Property(t => t.UpdatedBy).HasMaxLength(50);
            builder.Property(t => t.ModifiedByIp).HasMaxLength(50);

            builder.HasOne(t => t.Wallet)
                .WithMany(g => g.BalanceHistory)
                .HasForeignKey(f => f.WalletId);
        }
    }
}
