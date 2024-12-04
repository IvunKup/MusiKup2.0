namespace MusiKup.Domain.Entities.Files;

public class UserFile : BaseFile
{
    public User User { get; set; }
    public Guid UserId { get; set; }
}