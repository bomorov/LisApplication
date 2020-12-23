using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations
{
    public class SocialStatusConfiguration:IEntityTypeConfiguration<SocialStatus>
    {
        public void Configure(EntityTypeBuilder<SocialStatus> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(b => b.Name).IsRequired().HasMaxLength(200);
            builder.HasIndex(e => e.Code).IsUnique();
            builder.Property(b => b.Code).IsRequired().HasMaxLength(14);
            builder.Property(b => b.Coefficent).IsRequired().HasMaxLength(18);
        }
    }
}
