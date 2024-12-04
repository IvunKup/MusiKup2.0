using FluentValidation;
using MusiKup.Domain.Entities.Files;

namespace MusiKup.Domain.Validations.Validators;

public class PlaylistFileValidator : AbstractValidator<PlaylistFile>
{
    public PlaylistFileValidator()
    {
        Include(new BaseFileValidator());
        RuleFor(param => param.PlaylistId)
            .NotNullOrEmptyWithMessage(nameof(PlaylistFile));
    }
}