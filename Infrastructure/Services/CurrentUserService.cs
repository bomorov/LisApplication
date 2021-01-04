using Application.Common.Interfaces;
using Application.Identity;
using Domain.Enums;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;

namespace Infrastructure.Services
{
    public class CurrentUserService : ICurrentUserService
    {
        public int Id { get; set; }
        public string PIN { get; set; }
        public string FullName { get; set; }
        public int OrganizationId { get; set; }
        public int CoateId { get; set; }
        public bool IsRoot { get; set; }
        public List<string> RoleNames { get; set; }

        public CurrentUserService(IHttpContextAccessor httpContextAccessor)
        {
            string userId = httpContextAccessor.HttpContext?.User?.FindFirstValue(ClaimTypes.NameIdentifier);
            if (!string.IsNullOrEmpty(userId))
                Id = Convert.ToInt32(userId);

            PIN = httpContextAccessor.HttpContext?.User?.FindFirstValue(CustomClaimTypes.PIN);

            FullName = httpContextAccessor.HttpContext?.User?.FindFirstValue(CustomClaimTypes.FullName);

            string organizationId = httpContextAccessor.HttpContext?.User?.FindFirstValue(CustomClaimTypes.OrganizationId);
            if (!string.IsNullOrEmpty(organizationId))
                OrganizationId = Convert.ToInt32(organizationId);


            string isRoot = httpContextAccessor.HttpContext?.User?.FindFirstValue(CustomClaimTypes.IsRoot);
            if (!string.IsNullOrEmpty(isRoot))
                IsRoot = Convert.ToBoolean(isRoot);


            string roleNames = httpContextAccessor.HttpContext?.User?.FindFirstValue(CustomClaimTypes.RoleNames);
            if (!string.IsNullOrEmpty(roleNames))
                RoleNames = roleNames.Split(',').ToList();
        }
    }
}