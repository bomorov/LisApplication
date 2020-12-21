using Domain.Entities;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace Domain.Identity
{
    /// <summary>Таблица ролей</summary>
    public class ApplicationRole : IdentityRole<int>
    {
        /// <summary>Конструктор ролей</summary>
        public ApplicationRole()
        {
            UserRoles = new List<ApplicationUserRole>();
            RoleAccessRights = new List<RoleAccessRight>();
        }

        /// <summary>Флаг системной роли</summary>
        public bool IsRoot { get; set; }

        public virtual IList<ApplicationUserRole> UserRoles { get; set; }
        public virtual IList<RoleAccessRight> RoleAccessRights { get; set; }
    }
}