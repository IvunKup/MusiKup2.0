using MusiKup.Application.Interfases;
using MusiKup.Domain.Entities;
using MusiKup.Infrastructure.Dal.EntityFramework;

namespace MusiKup.Infrastructure.Dal.Repositories;

public class PerformerRepository : Repository<Performer>, IRepository<Performer>
{
    public PerformerRepository(MusiKupContext dbContext) : base(dbContext)
    {
    }
}