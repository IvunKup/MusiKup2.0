namespace MusiKup.Application.Dto.Response.Track;

public record TrackGetByIdResponse(string Title, Guid PerformerId, Guid AuthorId, Guid Id);