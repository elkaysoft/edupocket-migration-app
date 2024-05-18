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
    public class BusinessTypeConfiguration : IEntityTypeConfiguration<BusinessTypes>
    {
        public void Configure(EntityTypeBuilder<BusinessTypes> builder)
        {
            builder.ToTable("BusinessTypes", t => t.HasComment("The table business types information"));

            builder.HasKey(t => t.Id);
            builder.Property(t => t.Name).IsRequired().HasMaxLength(128);

            builder.Property(t => t.CreatedBy).HasMaxLength(50).IsRequired();
            builder.Property(t => t.DateCreated).IsRequired();
            builder.Property(t => t.CreatedByIp).HasMaxLength(50);

            builder.Property(t => t.UpdatedBy).HasMaxLength(50);
            builder.Property(t => t.ModifiedByIp).HasMaxLength(50);
        }
    }
}
