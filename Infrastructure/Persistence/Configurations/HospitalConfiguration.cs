using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations
{
    public class HospitalConfiguration:IEntityTypeConfiguration<Hospital>
    {
        public void Configure(EntityTypeBuilder<Hospital> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(b => b.Name).IsRequired().HasMaxLength(200);
            builder.HasIndex(e => e.Code).IsUnique();
            builder.Property(b => b.Code).IsRequired().HasMaxLength(14);
            builder.Property(b => b.DistrictId).IsRequired();
            builder.HasOne(p => p.District).WithMany(p=>p.Hospitals).HasForeignKey(p => p.DistrictId);
        }
    }
}
