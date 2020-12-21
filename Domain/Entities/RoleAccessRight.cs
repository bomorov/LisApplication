using Domain.Common;
using Domain.Enums;
using Domain.Identity;

namespace Domain.Entities
{
    /// <summary>Таблица прав доступа</summary>
    public class RoleAccessRight : BaseEntity
    {
        /// <summary>FK роли</summary>
        public int RoleId { get; set; }
        public ApplicationRole Role { get; set; }

        /// <summary>Тип доступа</summary>
        public AccessRigthsType AccessRigthsType { get; set; }

        /// <summary>Наименование доступа</summary>
        public string AccessRightsName { get; set; }

        /// <summary>Порядок следования</summary>
        public int Order { get; set; }
    }
}