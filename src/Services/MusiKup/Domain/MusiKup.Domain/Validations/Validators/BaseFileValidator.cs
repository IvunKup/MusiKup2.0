using FluentValidation;
using MusiKup.Domain.Entities.Files;
using MusiKup.Domain.Validations.Primitives;

namespace MusiKup.Domain.Validations.Validators;

public class BaseFileValidator : AbstractValidator<BaseFile>
{
    public BaseFileValidator()
    {
        RuleFor(param => param.FileName)
            .NotNullOrEmptyWithMessage(nameof(BaseFile.FileName))
            .Length(1, 100).WithMessage(ExceptionMessages.InvalidLength(nameof(BaseFile.FileName)));
        RuleFor(param => param.FilePath)
            .NotNullOrEmptyWithMessage(nameof(BaseFile.FilePath))
            .Must(Path.IsPathFullyQualified).WithMessage(ExceptionMessages.InvalidPath(nameof(BaseFile.FilePath)));
    }
}