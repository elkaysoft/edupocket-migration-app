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
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users", t => t.HasComment("The table stores user information"));

            builder.HasKey(t => t.Id);
            builder.Property(t => t.UserName).HasMaxLength(50).IsRequired();
            builder.Property(t => t.PasswordHash).HasMaxLength(1500).IsRequired();
            builder.Property(t => t.FirstName).HasMaxLength(50).IsRequired();
            builder.Property(t => t.LastName).HasMaxLength(50).IsRequired();
            builder.Property(t => t.Email).HasMaxLength(150).IsRequired();
            builder.Property(t => t.TransactionPinHash).HasMaxLength(1500);            
            builder.Property(t => t.Status).HasConversion<string>().HasMaxLength(15).IsRequired();

            builder.Property(t => t.CreatedBy).HasMaxLength(50).IsRequired();
            builder.Property(t => t.DateCreated).IsRequired();
            builder.Property(t => t.CreatedByIp).HasMaxLength(50);

            builder.Property(t => t.UpdatedBy).HasMaxLength(50);
            builder.Property(t => t.ModifiedByIp).HasMaxLength(50);
        }
    }
}
