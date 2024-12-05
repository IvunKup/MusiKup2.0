namespace MusiKup.Application.Dto.Request.Playlist;

public record PlaylistUpdateRequest(string Title, string Description, Guid Id);