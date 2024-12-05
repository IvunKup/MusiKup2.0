namespace MusiKup.Application.Dto.Request.AuthorFile;

public record AuthorFileUpdateRequest(Guid AuthorId, Guid FileId);