namespace MusiKup.Domain.Entities.Files;

public class PlaylistFile : BaseFile
{
    public Playlist Playlist { get; set; }
    public Guid PlaylistId { get; set; }
}