using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace Domain.Identity
{
    /// <summary>Таблица пользователей</summary>
    public class ApplicationUser : IdentityUser<int>
    {
        /// <summary>Конструктор пользователей</summary>
        public ApplicationUser()
        {
            UserRoles = new List<ApplicationUserRole>();
        }

        /// <summary>ИНН</summary>
        public string Pin { get; set; }

        /// <summary>Фамилия</summary>
        public string LastName { get; set; }

        /// <summary>Имя</summary>
        public string FirstName { get; set; }

        /// <summary>Отчество</summary>
        public string Patronymic { get; set; }

        /// <summary>Дата назначения</summary>
        public DateTime AssignmentDate { get; set; }

        /// <summary>Дата увольнения</summary>
        public DateTime? FairDate { get; set; }

        /// <summary>Флаг системного пользователя</summary>
        public bool IsRoot { get; set; }

        public virtual IList<ApplicationUserRole> UserRoles { get; set; }
    }
}