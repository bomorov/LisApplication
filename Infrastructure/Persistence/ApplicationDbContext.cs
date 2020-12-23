using Application.Common.Interfaces;
using Domain.Common;
using Domain.Entities;
using Infrastructure.Persistence.Seeds;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using System.Reflection;
using System.Security.Claims;
using System.Threading;
using System.Threading.Tasks;
using Infrastructure.Persistence.Configurations;

namespace Infrastructure.Persistence
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        private IDbContextTransaction _currentTransaction;
        private readonly IDateTime _dateTime;

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options,
            IDateTime dateTime) : base(options)
        {
            _dateTime = dateTime;
        }

        public DbSet<Hospital> Hospitals { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<District> Districts { get; set; }
        public DbSet<Branch> Branches { get; set; }
        public DbSet<Citizenship> Citizenships { get; set; }
        public DbSet<Extract> Extracts { get; set; }
        public DbSet<PrivilegesMedical> PrivilegesMedicals { get; set; }
        public DbSet<PrivilegesSocial> PrivilegesSocials { get; set; }
        public DbSet<RoleAccessRight> RoleAccessRights { get; set; }
        public DbSet<SocialStatus> SocialStatuses { get; set; }
        public DbSet<SurgicalOne> SurgicalOnes { get; set; }
        public DbSet<SurgicalTwo> SurgicalTwos { get; set; }
        public DbSet<SurgicalThree> SurgicalThrees { get; set; }




        public override Task<int> SaveChangesAsync(CancellationToken token = new CancellationToken())
        {
            int userId = 0;
            var httpContextAccessor = this.GetService<IHttpContextAccessor>();
            string userIdVal = httpContextAccessor.HttpContext?.User?.FindFirstValue(ClaimTypes.NameIdentifier);

            if (!string.IsNullOrEmpty(userIdVal))
                userId = Convert.ToInt32(userIdVal);

            foreach (var entry in ChangeTracker.Entries<AuditableEntity>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.CreatedBy = userId;
                        entry.Entity.Created = _dateTime.Now;
                        break;

                    case EntityState.Modified:
                        entry.Entity.LastModifiedBy = userId;
                        entry.Entity.LastModified = _dateTime.Now;
                        break;
                }
            }

            return base.SaveChangesAsync(token);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(builder);
            builder.AddDistrictSeedData();
            builder.AddRegionSeedData();
            builder.AddApplicationUserSeedData();
            builder.AddApplicationRoleSeedData();
            builder.AddApplicationUserRoleSeedData();

            builder.ApplyConfiguration(new ApplicationUserRoleConfiguration());
            foreach (var foreignKey in builder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                foreignKey.DeleteBehavior = DeleteBehavior.Restrict;
            }

            builder.SetPKAutoIncrementNumber();
        }
    }
}