using Domain.Common;

namespace Domain.Entities
{
    /// <summary>Таблица обновления токена</summary>
    public class RToken : BaseEntity
    {
        /// <summary>FK пользователя</summary>
        public int UserId { get; set; }

        /// <summary>Токен</summary>
        public string RefreshToken { get; set; }

        /// <summary>Флаг остановки</summary>
        public bool IsStop { get; set; }
    }
}