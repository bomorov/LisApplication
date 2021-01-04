using Application.Common.DTOs;
using Application.Common.Interfaces;
using Domain.Enums;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class AccessRightService : IAccessRightService
    {
        private readonly IApplicationDbContext _context;
        private readonly ICurrentUserService _userService;

        public AccessRightService(IApplicationDbContext context, ICurrentUserService userService)
        {
            _context = context;
            _userService = userService;
        }

        public async Task<List<DictEntityDto>> GetAccessRightsName()
        {
            return await _context.RoleAccessRights
                .Where(x => _userService.RoleNames.Contains(x.Role.Name) && x.AccessRigthsType > AccessRigthsType.Denied)
                .Select(x => new DictEntityDto
                {
                    Id = x.Order,
                    Name = x.AccessRightsName
                })
                .Distinct()
                .ToListAsync();
        }

        public async Task<bool> IsAllowed(string accessName, AccessRigthsType accessRigth)
        {
            return await _context.RoleAccessRights
                .Where(x => _userService.RoleNames.Contains(x.Role.Name)
                    && accessName.Contains(x.AccessRightsName)
                    && x.AccessRigthsType >= accessRigth)
                .AnyAsync();
        }
    }
}