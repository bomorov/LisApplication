using Domain.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Persistence.Configuration
{
    public class ApplicationUserConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {

            builder.Property(p => p.Pin).IsRequired().HasMaxLength(14);
            builder.Property(p => p.LastName).IsRequired().HasMaxLength(200);
            builder.Property(p => p.FirstName).IsRequired().HasMaxLength(200);

            builder.Property(p => p.IsRoot).IsRequired();

            builder.Property(p => p.AssignmentDate).IsRequired();

        }
    }
}
