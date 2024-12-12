namespace MusiKup.Application.Dto.Request.Track;

public record TrackCreateRequest(string Title, Guid PerformerId, Guid AuthorId);