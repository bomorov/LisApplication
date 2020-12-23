using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations
{
    public class PrivilegesSocialConfiguration:IEntityTypeConfiguration<PrivilegesSocial>
    {
        public void Configure(EntityTypeBuilder<PrivilegesSocial> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(b => b.Name).IsRequired().HasMaxLength(200);
            builder.HasIndex(e => e.Code).IsUnique();
            builder.Property(b => b.Code).IsRequired().HasMaxLength(14);
            builder.Property(b => b.CoefficentA).IsRequired().HasMaxLength(18);
            builder.Property(b => b.CoefficentB).IsRequired().HasMaxLength(18);

        }
    }
}
