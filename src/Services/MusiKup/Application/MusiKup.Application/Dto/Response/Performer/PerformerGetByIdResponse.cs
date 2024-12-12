namespace MusiKup.Application.Dto.Response.Performer;

public record PerformerGetByIdResponse(string Nickname, FullNameDto FullName, Guid Id);