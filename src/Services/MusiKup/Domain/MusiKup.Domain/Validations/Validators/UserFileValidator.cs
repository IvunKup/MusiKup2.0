using FluentValidation;
using MusiKup.Domain.Entities.Files;

namespace MusiKup.Domain.Validations.Validators;

public class UserFileValidator : AbstractValidator<UserFile>
{
    public UserFileValidator()
    {
        Include(new BaseFileValidator());
        RuleFor(param => param.UserId)
            .NotNullOrEmptyWithMessage(nameof(UserFile));
    }
}