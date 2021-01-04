using Application.Common.Interfaces;
using FluentValidation.Validators;

namespace Application.Common.Validators
{
    public class UniqueNameValidator<TModel> : PropertyValidator
        where TModel : class
    {
        private readonly IGenericRepository<TModel> _repo;
        private readonly string _columnName;
        private readonly string _columnRuName;

        public UniqueNameValidator(IGenericRepository<TModel> repo, string columnName, string columnRuName)
          : base($"Поле {columnRuName} должно быть уникальным")
        {
            _repo = repo;
            _columnName = columnName;
            _columnRuName = columnRuName;
        }

        protected override bool IsValid(PropertyValidatorContext context)
        {
            var newValue = context.PropertyValue as string;
            var isExist = _repo.IsExistByColumnName(newValue, _columnName, _columnRuName);
            return !isExist;
        }
    }
}