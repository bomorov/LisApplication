using System.Threading.Tasks;

namespace Application.Common.Interfaces
{
    public interface IGenericRepository<TModel>
        where TModel : class
    {
        bool IsExistByColumnName(string name, string columnName, string columnRuName);
    }
}