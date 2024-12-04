using FluentValidation;
using MusiKup.Domain.Validations.Primitives;
using MusiKup.Domain.ValueObjects;

namespace MusiKup.Domain.Validations.Validators;

public class FullNameValidator : AbstractValidator<FullName>
{
    public FullNameValidator()
    {
        RuleFor(param => param.FirstName)
            .NotNullOrEmptyWithMessage(nameof(FullName.FirstName))
            .Matches(@"^([А-ЯЁA-Z][а-яёa-z]+)(-[А-ЯЁA-Z][а-яёa-z]+)?$")
            .WithMessage(ExceptionMessages.InvalidSpelling(nameof(FullName.FirstName)))
            .Length(50).WithMessage(ExceptionMessages.InvalidLength(nameof(FullName.FirstName)));
        RuleFor(param => param.LastName)
            .NotNullOrEmptyWithMessage(nameof(FullName.LastName))
            .Matches(@"^([А-ЯЁA-Z][а-яёa-z]+)(-[А-ЯЁA-Z][а-яёa-z]+)?$")
            .WithMessage(ExceptionMessages.InvalidSpelling(nameof(FullName.LastName)))
            .Length(50).WithMessage(ExceptionMessages.InvalidLength(nameof(FullName.LastName)));
        RuleFor(param => param.MiddleName)
            .MaximumLength(50).When(param => !string.IsNullOrEmpty(param.MiddleName))
            .Matches(@"^([А-ЯЁA-Z][а-яёa-z]+)(-[А-ЯЁA-Z][а-яёa-z]+)?$")
            .WithMessage(ExceptionMessages.InvalidSpelling(nameof(FullName.MiddleName)))
            .When(param => !string.IsNullOrEmpty(param.MiddleName))
            .WithMessage(ExceptionMessages.InvalidSpelling(nameof(FullName.MiddleName)));
    }
}