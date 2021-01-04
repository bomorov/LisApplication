using Application.Common.Interfaces;
using Application.Common.Models;
using AutoMapper;
using Domain.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using P.Pager;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    // add just to commit
    public class RoleService : IRoleService
    {
        private readonly RoleManager<ApplicationRole> _roleManager;
        private readonly IMapper _mapper;

        public RoleService(RoleManager<ApplicationRole> roleManager, IMapper mapper)
        {
            _roleManager = roleManager;
            _mapper = mapper;
        }

        public async Task<IList<ApplicationRole>> GetRolesAsync()
        {
            return await _roleManager.Roles.Include(x => x.RoleAccessRights).Where(x => !x.IsRoot).ToListAsync();
        }

        public async Task<IList<ApplicationRole>> GetRolesWithRootAsync()
        {
            return await _roleManager.Roles.Include(x => x.RoleAccessRights).Where(r => r.Name != "Суперадмин").ToListAsync();
        }

        public async Task<ApplicationRole> GetRoleByIdAsync(int id)
        {
            return await _roleManager.FindByIdAsync(id.ToString());
        }

        public async Task<ApplicationRole> GetRoleIncludedByIdAsync(int id, CancellationToken cancellationToken)
        {
            return await _roleManager.Roles.Include(x => x.RoleAccessRights).SingleOrDefaultAsync(x => x.Id == id, cancellationToken);
        }

        public async Task<int> CreateRoleAsync(ApplicationRole applicationRole)
        {
            await _roleManager.CreateAsync(applicationRole);
            return applicationRole.Id;
        }

        public async Task<Result> UpdateRoleAsync(ApplicationRole applicationRole)
        {
            var identityResult = await _roleManager.UpdateAsync(applicationRole);
            return identityResult.ToApplicationResult();
        }

        public async Task<Result> DeleteRoleAsync(int id)
        {
            var role = await _roleManager.FindByIdAsync(id.ToString());
            if (role == null)
                return Result.Failure(InfrastructureResources.RecordNotFoundError);

            var identityResult = await _roleManager.DeleteAsync(role);
            return identityResult.ToApplicationResult();
        }
    }
}