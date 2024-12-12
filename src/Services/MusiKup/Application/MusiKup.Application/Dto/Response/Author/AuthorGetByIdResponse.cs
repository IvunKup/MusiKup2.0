namespace MusiKup.Application.Dto.Response.Author;

public record AuthorGetByIdResponse(string Nickname, FullNameDto FullName, Guid Id);