using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Common.Interfaces
{
    public interface IApplicationDbContext
    {
        public DbSet<Region> Regions { get; set; }
        public DbSet<Hospital> Hospitals { get; set; }
        public  DbSet<Area> Areas { get; set; }
        Task<int> SaveChangesAsync(CancellationToken token);
    }
}
