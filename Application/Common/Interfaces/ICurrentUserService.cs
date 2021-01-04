using Domain.Enums;
using System.Collections.Generic;

namespace Application.Common.Interfaces
{
    public interface ICurrentUserService
    {
        int Id { get; set; }
        string PIN { get; set; }
        string FullName { get; set; }
        int OrganizationId { get; set; }
        int CoateId { get; set; }
        bool IsRoot { get; set; }
        List<string> RoleNames { get; set; }
    }
}