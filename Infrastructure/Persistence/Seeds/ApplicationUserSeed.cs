using Domain.Enums;
using Domain.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;

namespace Infrastructure.Persistence.Seeds
{
    internal static class ApplicationUserSeed
    {
        private static DateTime _initialDate = new DateTime(1970, 1,1);
        internal static ModelBuilder AddApplicationUserSeedData(this ModelBuilder builder)
        {
            const string password = "root1234";
            var users = new ApplicationUser[]
            {
                new ApplicationUser
                {
                    Id = 1,
                    UserName = "00000000000001",
                    LastName = "Супер",
                    FirstName = "администратор",
                    Pin = "00000000000001",
                    AssignmentDate = _initialDate,
                    IsRoot = true,
                    NormalizedEmail = "00000000000001".ToUpper(),
                    NormalizedUserName = "00000000000001".ToUpper(),
                    SecurityStamp = "0382afaf-aeae-47ef-983d-c194ba94c64e",
                    ConcurrencyStamp = "c94b51e5-52f3-4a06-a91b-f22a1588f9a4",
                },

            };
            foreach (var user in users)
            {
                user.PasswordHash = new PasswordHasher<ApplicationUser>().HashPassword(user, password);
            }
            builder.Entity<ApplicationUser>().HasData(users);

            return builder;
        }

        internal static ModelBuilder AddApplicationRoleSeedData(this ModelBuilder builder)
        {
            var roles = new ApplicationRole[]
            {
                new ApplicationRole
                {
                    Id = 1,
                    ConcurrencyStamp = "0405cb6c-6b34-4407-9c48-836885d581d3",
                    Name = "Суперадмин",
                    NormalizedName = "Суперадмин".ToUpper(),
                    IsRoot = true
                },
                new ApplicationRole
                {
                    Id = 2,
                    ConcurrencyStamp = "598b1376-5f40-40b5-a069-b3d89e8a1b68",
                    Name = "Администратор",
                    NormalizedName = "Администратор".ToUpper(),
                    IsRoot = true
                },
              
            };

            builder.Entity<ApplicationRole>().HasData(roles);

            return builder;
        }

        internal static ModelBuilder AddApplicationUserRoleSeedData(this ModelBuilder builder)
        {
            var userRoles = new ApplicationUserRole[]
            {
                new ApplicationUserRole
                {
                    UserId = 1,
                    RoleId = 1
                },
             
            };

            builder.Entity<ApplicationUserRole>().HasData(userRoles);

            return builder;
        }
    }
}