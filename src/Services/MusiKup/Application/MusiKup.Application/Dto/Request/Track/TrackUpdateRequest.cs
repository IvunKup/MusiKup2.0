namespace MusiKup.Application.Dto.Request.Track;

public record TrackUpdateRequest(string Title, Guid PerformerId, Guid AuthorId, Guid Id);