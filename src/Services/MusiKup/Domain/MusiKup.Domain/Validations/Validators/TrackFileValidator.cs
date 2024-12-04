using FluentValidation;
using MusiKup.Domain.Entities.Files;

namespace MusiKup.Domain.Validations.Validators;

public class TrackFileValidator : AbstractValidator<TrackFile>
{
    public TrackFileValidator()
    {
        Include(new BaseFileValidator());
        RuleFor(param => param.TrackId)
            .NotNullOrEmptyWithMessage(nameof(TrackFile));
    }
}