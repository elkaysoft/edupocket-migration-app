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
    public class WalletSchemeConfiguration : IEntityTypeConfiguration<WalletScheme>
    {
        public void Configure(EntityTypeBuilder<WalletScheme> builder)
        {
            builder.ToTable("WalletScheme", t => t.HasComment("The table stores wallet scheme information"));

            builder.HasKey(t => t.Id);
            builder.Property(t => t.Name).IsRequired().HasMaxLength(128);
            builder.Property(t => t.Code).IsRequired().HasMaxLength(28);
            builder.Property(t => t.WalletSchemeType).HasConversion<string>().HasMaxLength(15);            

            builder.Property(t => t.CreatedBy).HasMaxLength(50).IsRequired();
            builder.Property(t => t.DateCreated).IsRequired();
            builder.Property(t => t.CreatedByIp).HasMaxLength(50);

            builder.Property(t => t.UpdatedBy).HasMaxLength(50);
            builder.Property(t => t.ModifiedByIp).HasMaxLength(50);
        }
    }
}
