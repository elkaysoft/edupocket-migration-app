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
    public class SystemWalletAccountTransactionConfiguration : IEntityTypeConfiguration<SystemWalletAccountTransaction>
    {
        public void Configure(EntityTypeBuilder<SystemWalletAccountTransaction> builder)
        {
            builder.ToTable("WalletSchemeAccountTransactions", t => t.HasComment("The table holds wallet scheme account transactions"));

            builder.HasKey(t => t.Id);
            builder.Property(t => t.WalletSchemeAccountId).IsRequired().HasMaxLength(50);
            builder.Property(t => t.TransactionReference).IsRequired().HasMaxLength(50);
            builder.Property(t => t.TransactionId).IsRequired().HasMaxLength(50);
            builder.Property(t => t.Amount).IsRequired().HasPrecision(18, 2);
            builder.Property(t => t.CheckSum).IsRequired().HasMaxLength(250);
            builder.Property(t => t.TransactionRecordType).HasConversion<string>().IsRequired();

            builder.Property(t => t.CreatedBy).HasMaxLength(50).IsRequired();
            builder.Property(t => t.DateCreated).IsRequired();
            builder.Property(t => t.CreatedByIp).HasMaxLength(50);

            builder.Property(t => t.UpdatedBy).HasMaxLength(50);
            builder.Property(t => t.ModifiedByIp).HasMaxLength(50);

            builder.HasOne(ft => ft.Transaction)
                .WithMany()
                .HasForeignKey(fk => fk.TransactionId);

            builder.HasOne(ft => ft.WalletSchemeAccount)
                .WithMany()
                .HasForeignKey(fk => fk.WalletSchemeAccountId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
