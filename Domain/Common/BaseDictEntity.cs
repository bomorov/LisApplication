namespace Domain.Common
{
    /// <summary>Общий базовый класс для справочников</summary>
    public  class BaseDictEntity:AuditableEntity
    {

        /// <summary>Наименование</summary>
        public string Name { get; set; }

        /// <summary>Код</summary>
        public string Code { get; set; }
    }
}