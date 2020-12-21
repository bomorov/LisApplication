namespace Domain.Common
{
    /// <summary>Общий базовый класс для справочников</summary>
    public abstract class BaseDictEntity
    {
        /// <summary>PK</summary>
        public int Id { get; set; }

        /// <summary>Наименование</summary>
        public string Name { get; set; }
    }
}