namespace MusiKup.Application.Dto.Response.Author;

public record AuthorGetBiIdResponse(string Nickname, FullNameDto FullName, Guid Id);