namespace MusiKup.Application.Dto.Response.Author;

public record AuthorCreateResponse(Guid Id, string NickName, FullNameDto FullName);