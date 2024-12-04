namespace MusiKup.Domain.Entities.Files;

public class AuthorFile : BaseFile
{
    public Author Author { get; set; }
    public Guid AuthorId { get; set; }
}