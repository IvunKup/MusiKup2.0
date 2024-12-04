using MusiKup.Domain.Entities.Files;
using MusiKup.Domain.ValueObjects;

namespace MusiKup.Domain.Entities;

public class Author : BaseEntity
{
    public ICollection<Track> Tracks { get; set; }

    public string NickName { get; set; }

    public FullName FullName { get; set; }

    public ICollection<AuthorFile> AuthorFiles { get; set; }

    public Author(string nickName, FullName fullName)
    {
        NickName = nickName;
        FullName = fullName;
    }

    public Author()
    {
    }
}