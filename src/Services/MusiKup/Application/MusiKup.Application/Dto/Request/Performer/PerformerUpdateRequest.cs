namespace MusiKup.Application.Dto.Request.Performer;

public record PerformerUpdateRequest(string Nickname, FullNameDto FullName, Guid Id);