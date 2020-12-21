using Application.Common.Interfaces;
using Audit.EntityFramework;
using Domain.Common;
using Domain.Entities;
using Domain.Identity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Linq;
using System.Reflection;
using System.Security.Claims;
using Microsoft.Extensions.DependencyInjection;
using System.Threading;
using System.Threading.Tasks;

namespace Infrastructure.Persistence
{
    public class ApplicationDbContext : DbContext,IApplicationDbContext
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
        }
    }
}