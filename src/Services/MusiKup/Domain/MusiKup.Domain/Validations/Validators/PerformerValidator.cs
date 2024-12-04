using FluentValidation;
using MusiKup.Domain.Entities;
using MusiKup.Domain.Validations.Primitives;

namespace MusiKup.Domain.Validations.Validators;

public class PerformerValidator : AbstractValidator<Performer>
{
    public PerformerValidator()
    {
        RuleFor(param => param.NickName)
            .NotNullOrEmptyWithMessage(nameof(Performer.NickName))
            .Length(1, 100).WithMessage(ExceptionMessages.InvalidLength(nameof(Performer.NickName)));
        RuleFor(param => param.FullName)
            .SetValidator(new FullNameValidator());
    }
}