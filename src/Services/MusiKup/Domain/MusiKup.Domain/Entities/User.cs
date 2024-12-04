using Microsoft.AspNetCore.Identity;
using MusiKup.Domain.Entities.Files;

namespace MusiKup.Domain.Entities;

public class User : IdentityUser<Guid>
{
    public ICollection<UserFile> UserFiles { get; set; }

    public User()
    {
    }
}