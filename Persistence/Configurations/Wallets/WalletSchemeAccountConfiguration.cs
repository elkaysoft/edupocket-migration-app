using Domain.Entities.Wallets;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations.Wallets
{
    public class WalletSchemeAccountConfiguration : IEntityTypeConfiguration<WalletSchemeAccount>
    {
        public void Configure(EntityTypeBuilder<WalletSchemeAccount> builder)
        {
            builder.ToTable("WalletSchemeAccount", t => t.HasComment("The table stores wallet scheme account records"));

            builder.HasKey(t => t.Id);
            builder.Property(t => t.WalletSchemeId).IsRequired().HasMaxLength(58);
            builder.Property(t => t.AccountNumber).IsRequired().HasMaxLength(25);
            builder.Property(t => t.Balance).IsRequired().HasPrecision(18,2);
            builder.Property(t => t.CheckSum).IsRequired().HasMaxLength(250);

            builder.Property(t => t.CreatedBy).HasMaxLength(50).IsRequired();
            builder.Property(t => t.DateCreated).IsRequired();
            builder.Property(t => t.CreatedByIp).HasMaxLength(50);

            builder.Property(t => t.UpdatedBy).HasMaxLength(50);
            builder.Property(t => t.ModifiedByIp).HasMaxLength(50);
        }
    }
}
