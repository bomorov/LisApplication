using Application.Common.Models;
using Domain.Identity;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Common.Interfaces
{
    public interface IRoleService
    {
        Task<IList<ApplicationRole>> GetRolesAsync();

        Task<IList<ApplicationRole>> GetRolesWithRootAsync();

        Task<ApplicationRole> GetRoleByIdAsync(int id);

        Task<ApplicationRole> GetRoleIncludedByIdAsync(int id, CancellationToken cancellationToken);

        Task<int> CreateRoleAsync(ApplicationRole applicationRole);

        Task<Result> UpdateRoleAsync(ApplicationRole applicationRole);

        Task<Result> DeleteRoleAsync(int id);
    }
}