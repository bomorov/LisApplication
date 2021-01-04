using System;
using System.Collections.Generic;
using System.Text;
using Application.Common.Interfaces;
using Application.Common.Validators;
using Domain.Entities;
using FluentValidation;

namespace Application.MediatR.Districts.Commands
{
    public class CreateDistrictCommandValidator : AbstractValidator<CreateDistrictCommand>
    {
        public CreateDistrictCommandValidator(IGenericRepository<District> repo)
        {
            RuleFor(v => v.Name)
                .NotEmpty().WithMessage(ApplicationResources.FieldRequiredValidation)
                .MaximumLength(200).WithMessage(ApplicationResources.MaxLengthValidation)
                .SetValidator(new UniqueNameValidator<District>(repo, "Name", "Наименование"));
            RuleFor(v=>v.Code)
                .MinimumLength(14).WithMessage(ApplicationResources.MinimumLengthValidation)
                .MaximumLength(14).WithMessage(ApplicationResources.MaxLengthValidation)
                .Matches("^[0-9]*$").WithMessage(ApplicationResources.MatchNumbers)
                .SetValidator(new UniqueNameValidator<District>(repo, "Code", "Код"));


        }
    }
}
