namespace MusiKup.Domain.Entities.Files;

public class TrackFile : BaseFile
{
    public Track Track { get; set; }
    public Guid TrackId { get; set; }
}