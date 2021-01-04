using Application.Common.Interfaces;
using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Infrastructure.Services
{
    public class GenericRepository<TModel> : IGenericRepository<TModel>
        where TModel : class
    {
        protected readonly ApplicationDbContext _dbContext;

        public GenericRepository(ApplicationDbContext context)
        {
            _dbContext = context;
        }

        public bool IsExistByColumnName(string name, string columnName, string columnRuName)
        {
            return _dbContext.Set<TModel>().Where(e => EF.Property<string>(e, columnName) == name).Any();
        }
    }
}