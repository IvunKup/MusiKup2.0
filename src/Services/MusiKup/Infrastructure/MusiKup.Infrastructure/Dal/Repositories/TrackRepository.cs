using MusiKup.Application.Interfases;
using MusiKup.Domain.Entities;
using MusiKup.Infrastructure.Dal.EntityFramework;

namespace MusiKup.Infrastructure.Dal.Repositories;

public class TrackRepository : Repository<Track>, IRepository<Track>
{
    public TrackRepository(MusiKupContext dbContext) : base(dbContext)
    {
    }
}