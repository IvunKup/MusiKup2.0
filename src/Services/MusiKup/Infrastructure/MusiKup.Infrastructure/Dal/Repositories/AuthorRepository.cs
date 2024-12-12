using Microsoft.EntityFrameworkCore;
using MusiKup.Application.Interfases;
using MusiKup.Domain.Entities;

namespace MusiKup.Infrastructure.Dal.Repositories;

public class AuthorRepository : Repository<Author>, IRepository<Author>
{
    protected AuthorRepository(DbContext dbContext) : base(dbContext)
    {
    }
}