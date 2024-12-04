using MusiKup.Domain.Entities.Files;
using MusiKup.Domain.Validations.Primitives;

namespace MusiKup.Domain.Entities;

public class Track : BaseEntity
{
    public Genre Genre { get; set; }

    public string Title { get; set; }

    public Author Author { get; set; }

    public Guid AuthorId { get; set; }

    public Performer Performer { get; set; }

    public Guid PerformerId { get; set; }

    public ICollection<Playlist> Playlists { get; set; }

    public ICollection<TrackFile> TrackFiles { get; set; }

    public Track()
    {
    }
}