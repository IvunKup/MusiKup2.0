namespace MusiKup.Application.Dto.Response.Author;

public record AuthorUpdateResponse(string Nickname, FullNameDto FullName, Guid Id);