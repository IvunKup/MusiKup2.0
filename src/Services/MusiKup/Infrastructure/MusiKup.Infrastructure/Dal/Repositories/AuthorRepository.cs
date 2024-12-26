using MusiKup.Application.Interfases;
using MusiKup.Domain.Entities;
using MusiKup.Infrastructure.Dal.EntityFramework;

namespace MusiKup.Infrastructure.Dal.Repositories;

public class AuthorRepository : Repository<Author>, IRepository<Author>
{
    public AuthorRepository(MusiKupContext dbContext) : base(dbContext)
    {
    }
}