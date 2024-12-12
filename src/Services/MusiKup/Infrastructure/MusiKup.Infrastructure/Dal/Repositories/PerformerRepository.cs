using Microsoft.EntityFrameworkCore;
using MusiKup.Application.Interfases;
using MusiKup.Domain.Entities;

namespace MusiKup.Infrastructure.Dal.Repositories;

public class PerformerRepository : Repository<Performer>, IRepository<Performer>
{
    protected PerformerRepository(DbContext dbContext) : base(dbContext)
    {
    }
}