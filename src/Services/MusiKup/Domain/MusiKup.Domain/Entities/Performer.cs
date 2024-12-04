using MusiKup.Domain.Entities.Files;
using MusiKup.Domain.ValueObjects;

namespace MusiKup.Domain.Entities;

public class Performer : BaseEntity
{
    public ICollection<Track> Tracks { get; set; }

    public string NickName { get; set; }

    public FullName FullName { get; set; }

    public ICollection<PerformerFile> PerformerFiles { get; set; }

    public Performer(string nickName, FullName fullName)
    {
        NickName = nickName;
        FullName = fullName;
    }

    public Performer()
    {
    }
}