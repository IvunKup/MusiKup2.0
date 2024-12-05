namespace MusiKup.Application.Dto.Request.Author;

public record AuthorUpdateRequest(string Nickname, FullNameDto FullName, Guid Id);