using MusiKup.Domain.Entities.Files;

namespace MusiKup.Domain.Entities;

public class Playlist : BaseEntity
{
    public string Title { get; set; }
    public string Description { get; set; }

    public ICollection<Track> Tracks { get; set; }

    public ICollection<PlaylistFile> PlaylistFiles { get; set; }

    public Playlist(Guid id, DateTime createOn, DateTime modifiedOn, string title, string description)
    {
        Id = id;
        CreatedOn = createOn;
        ModifiedOn = modifiedOn;
        Title = title;
        Description = description;
    }

    public Playlist()
    {
    }
}