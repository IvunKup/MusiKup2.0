namespace MusiKup.Application.Dto.Response.Track;

public record TrackUpdateResponse(string Title, Guid PerformerId, Guid AuthorId, Guid Id);