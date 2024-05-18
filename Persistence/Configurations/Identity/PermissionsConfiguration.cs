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
    public class PermissionsConfiguration : IEntityTypeConfiguration<Permissions>
    {
        public void Configure(EntityTypeBuilder<Permissions> builder)
        {
            builder.ToTable("Permissions", t => t.HasComment("The table stores permission information"));

            builder.HasKey(t => t.Id);
            builder.Property(t => t.Name).HasMaxLength(50).IsRequired();
            builder.Property(t => t.Description).HasMaxLength(150).IsRequired();
            builder.Property(t => t.ShortName).HasMaxLength(50).IsRequired();
            builder.Property(t => t.GroupName).HasMaxLength(50);

            builder.Property(t => t.CreatedBy).HasMaxLength(50).IsRequired();
            builder.Property(t => t.DateCreated).IsRequired();
            builder.Property(t => t.CreatedByIp).HasMaxLength(50);

            builder.Property(t => t.UpdatedBy).HasMaxLength(50);
            builder.Property(t => t.ModifiedByIp).HasMaxLength(50);
        }
    }
}
