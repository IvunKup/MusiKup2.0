using Microsoft.EntityFrameworkCore;
using MusiKup.Application.Interfases;
using MusiKup.Domain.Entities.Files;

namespace MusiKup.Infrastructure.Dal.Repositories;

public class AuthorFileRepository : Repository<AuthorFile>, IRepository<AuthorFile>
{
    protected AuthorFileRepository(DbContext dbContext) : base(dbContext)
    {
    }
}