using Application.Common.Interfaces;
using Microsoft.AspNetCore.Http;
using System;
using System.Security.Claims;

namespace Infrastructure.Services
{
    public class HttpContextUserService : IHttpContextUserService
    {
        public int UserId { get; }

        public HttpContextUserService(IHttpContextAccessor httpContextAccessor)
        {
            string userId = httpContextAccessor.HttpContext?.User?.FindFirstValue(ClaimTypes.NameIdentifier);

            if (!string.IsNullOrEmpty(userId))
                UserId = Convert.ToInt32(userId);
        }
    }
}