using Domain.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Persistence.Configurations
{
    public class ApplicationUserRoleConfiguration : IEntityTypeConfiguration<ApplicationUserRole>
    {
        public void Configure(EntityTypeBuilder<ApplicationUserRole> builder)
        {
            builder.HasKey(k => new { k.UserId, k.RoleId });

            builder.HasOne(c => c.Role).WithMany(m => m.UserRoles).HasForeignKey(b => b.RoleId);
            builder.HasOne(c => c.User).WithMany(m => m.UserRoles).HasForeignKey(b => b.UserId);
        }
    }
}
