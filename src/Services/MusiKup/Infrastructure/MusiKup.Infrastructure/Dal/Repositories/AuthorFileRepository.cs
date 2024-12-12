using MusiKup.Application.Interfases;
using MusiKup.Domain.Entities.Files;
using MusiKup.Infrastructure.Dal.EntityFramework;

namespace MusiKup.Infrastructure.Dal.Repositories;

public class AuthorFileRepository : Repository<AuthorFile>, IRepository<AuthorFile>
{
    public AuthorFileRepository(MusiKupContext dbContext) : base(dbContext)
    {
    }
}