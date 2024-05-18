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
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.ToTable("Students", t => t.HasComment("The table student information"));

            builder.HasKey(t => t.Id);
            builder.Property(t => t.FirstName).IsRequired().HasMaxLength(50);
            builder.Property(t => t.LastName).IsRequired().HasMaxLength(50);
            builder.Property(t => t.OtherNames).HasMaxLength(50);
            builder.Property(t => t.WalletNumber).IsRequired().HasMaxLength(10);
            builder.Property(t => t.Gender).IsRequired().HasMaxLength(10);
            builder.Property(t => t.Department).HasMaxLength(150);
            builder.Property(t => t.Institution).IsRequired().HasMaxLength(150);
            builder.Property(t => t.EmailAddress).IsRequired().HasMaxLength(150);
            builder.Property(t => t.PhoneNumber).HasMaxLength(15);
            builder.Property(t => t.CurrentLevel).HasMaxLength(20);
            builder.Property(t => t.Status).IsRequired().HasMaxLength(20).HasConversion<string>();
            builder.Property(t => t.CheckSum).IsRequired().HasMaxLength(500);

            builder.Property(t => t.CreatedBy).HasMaxLength(50).IsRequired();
            builder.Property(t => t.DateCreated).IsRequired();
            builder.Property(t => t.CreatedByIp).HasMaxLength(50);

            builder.Property(t => t.UpdatedBy).HasMaxLength(50);
            builder.Property(t => t.ModifiedByIp).HasMaxLength(50);
        }
    }
}
