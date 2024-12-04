using FluentValidation;
using MusiKup.Domain.Entities.Files;

namespace MusiKup.Domain.Validations.Validators;

public class PerformerFileValidator : AbstractValidator<PerformerFile>
{
    public PerformerFileValidator()
    {
        Include(new BaseFileValidator());
        RuleFor(param => param.PerformerId)
            .NotNullOrEmptyWithMessage(nameof(PerformerFile));
    }
}