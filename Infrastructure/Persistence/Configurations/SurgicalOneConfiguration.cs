using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations
{
    public  class SurgicalOneConfiguration:IEntityTypeConfiguration<SurgicalOne>
    {
        public void Configure(EntityTypeBuilder<SurgicalOne> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(b => b.Name).IsRequired().HasMaxLength(200);
            builder.HasIndex(e => e.Code).IsUnique();
            builder.Property(b => b.Code).IsRequired().HasMaxLength(14);
            builder.Property(b => b.SurgicalGroupId).IsRequired();
            builder.HasOne(p => p.SurgicalGroup).WithMany(p => p.SurgicalOnes).HasForeignKey(p => p.SurgicalGroupId);
        }
    }
}
