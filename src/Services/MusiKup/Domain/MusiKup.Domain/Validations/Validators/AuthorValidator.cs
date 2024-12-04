using FluentValidation;
using MusiKup.Domain.Entities;
using MusiKup.Domain.Validations.Primitives;

namespace MusiKup.Domain.Validations.Validators;

public class AuthorValidator : AbstractValidator<Author>
{
    public AuthorValidator()
    {
        RuleFor(param => param.NickName)
            .NotNullOrEmptyWithMessage(nameof(Author.NickName))
            .Length(1, 100).WithMessage(ExceptionMessages.InvalidLength(nameof(Author.NickName)));
        RuleFor(param => param.FullName)
            .SetValidator(new FullNameValidator());
    }
}