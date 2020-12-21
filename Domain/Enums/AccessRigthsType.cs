using System.ComponentModel.DataAnnotations;

namespace Domain.Enums
{
    /// <summary>Тип доступа</summary>
    public enum AccessRigthsType
    {
        /// <summary>Отсутствует доступ</summary>
        [Display(Name = "Отсутствует доступ")]
        Denied = 0,

        /// <summary>Просмотр</summary>
        [Display(Name = "Просмотр")]
        Read = 10,

        /// <summary>Полный доступ</summary>
        [Display(Name = "Полный доступ")]
        Full = 50,
    }
}