using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations
{
    public class SurgicalThreeConfiguration : IEntityTypeConfiguration<SurgicalThree>
    {
        public void Configure(EntityTypeBuilder<SurgicalThree> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(b => b.Name).IsRequired().HasMaxLength(200);
            builder.HasIndex(e => e.Code).IsUnique();
            builder.Property(b => b.Code).IsRequired().HasMaxLength(14);
            builder.Property(b => b.SurgicalTwoId).IsRequired();
            builder.HasOne(p => p.SurgicalTwo).WithMany(p => p.SurgicalThrees).HasForeignKey(p => p.SurgicalTwoId);
        }
    }
}
