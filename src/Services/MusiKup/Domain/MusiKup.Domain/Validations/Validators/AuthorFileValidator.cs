using FluentValidation;
using MusiKup.Domain.Entities.Files;

namespace MusiKup.Domain.Validations.Validators;

public class AuthorFileValidator : AbstractValidator<AuthorFile>
{
    public AuthorFileValidator()
    {
        Include(new BaseFileValidator());
        RuleFor(param => param.AuthorId)
            .NotNullOrEmptyWithMessage(nameof(AuthorFile));
    }
}