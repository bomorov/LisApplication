using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Common.Interfaces
{
    public interface IApplicationDbContext
    {
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
        Task<int> SaveChangesAsync(CancellationToken token);
    }
}
