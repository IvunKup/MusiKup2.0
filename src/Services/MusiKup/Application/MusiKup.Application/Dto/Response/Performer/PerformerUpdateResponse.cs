namespace MusiKup.Application.Dto.Response.Performer;

public record PerformerUpdateResponse(string Nickname, FullNameDto FullName, Guid Id);