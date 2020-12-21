using Application.Common.Interfaces;
using Audit.EntityFramework;
using Domain.Common;
using Domain.Entities;
using Domain.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;

namespace Infrastructure.Persistence
{
    public class ApplicationDbContext : AuditIdentityDbContext<ApplicationUser, ApplicationRole, int, IdentityUserClaim<int>, ApplicationUserRole,
        IdentityUserLogin<int>, IdentityRoleClaim<int>, IdentityUserToken<int>>, IApplicationDbContext
    {
        public DbSet<Hospital> Hospitals { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Area> Areas { get; set; }
    
    }
}