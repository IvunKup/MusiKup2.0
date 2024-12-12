namespace MusiKup.Application.Dto.Response.Track;

public record TrackCreateResponse(Guid Id, string Title, Guid PerformerId, Guid AuthorId);