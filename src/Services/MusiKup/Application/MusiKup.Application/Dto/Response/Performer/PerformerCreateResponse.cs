namespace MusiKup.Application.Dto.Response.Performer;

public record PerformerCreateResponse(Guid Id, string NickName, FullNameDto FullName);