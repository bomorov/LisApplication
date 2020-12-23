using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entities;
using Domain.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations
{
    public class RegionConfiguration:IEntityTypeConfiguration<Region>
    {
        public void Configure(EntityTypeBuilder<Region> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(b => b.Name).IsRequired().HasMaxLength(200);
            builder.HasIndex(e => e.Code).IsUnique();
            builder.Property(b => b.Code).IsRequired().HasMaxLength(14); 
        }
    }
}
