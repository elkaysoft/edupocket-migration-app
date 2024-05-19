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
    public class TransactionConfiguration : IEntityTypeConfiguration<Transaction>
    {
        public void Configure(EntityTypeBuilder<Transaction> builder)
        {
            builder.ToTable("Wallet", t => t.HasComment("The table stores wallet transactions information"));

            builder.HasKey(t => t.Id);
            builder.Property(t => t.Amount).HasPrecision(18, 2).IsRequired();
            builder.Property(t => t.Checksum).HasMaxLength(500).IsRequired();
            builder.Property(t => t.Description).HasMaxLength(500).IsRequired();
            builder.Property(t => t.TransactionStatus).HasConversion<string>().HasMaxLength(50).IsRequired();
            builder.Property(t => t.TransactionType).HasConversion<string>().HasMaxLength(50).IsRequired();
            builder.Property(t => t.DestinationAccountName).HasMaxLength(150);
            builder.Property(t => t.DestinationAccountNumber).HasMaxLength(150);
            builder.Property(t => t.DestinationBankCode).HasMaxLength(150);
            builder.Property(t => t.DestinationWalletId).HasMaxLength(50);
            builder.Property(t => t.SourceWalletId).HasMaxLength(50);
            builder.Property(t => t.ServiceResponse).HasMaxLength(1000);
            builder.Property(t => t.TransactionReference).HasMaxLength(150);
            builder.Property(t => t.TransactionRecordType).HasConversion<string>().HasMaxLength(10);
            builder.Property(t => t.TransactionStatus).HasConversion<string>().HasMaxLength(10);


            builder.Property(t => t.CreatedBy).HasMaxLength(50).IsRequired();
            builder.Property(t => t.DateCreated).IsRequired();
            builder.Property(t => t.CreatedByIp).HasMaxLength(50);

            builder.Property(t => t.UpdatedBy).HasMaxLength(50);
            builder.Property(t => t.ModifiedByIp).HasMaxLength(50);
        }
    }
}
