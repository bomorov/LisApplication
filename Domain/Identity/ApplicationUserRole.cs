using Microsoft.AspNetCore.Identity;

namespace Domain.Identity
{
    /// <summary>Таблица пользователь-роль</summary>
    public class ApplicationUserRole : IdentityUserRole<int>
    {
        /// <summary>FK роли</summary>
        public override int RoleId { get; set; }
        public virtual ApplicationRole Role { get; set; }

        /// <summary>FK пользователя</summary>
        public override int UserId { get; set; }
        public virtual ApplicationUser User { get; set; }
    }
}