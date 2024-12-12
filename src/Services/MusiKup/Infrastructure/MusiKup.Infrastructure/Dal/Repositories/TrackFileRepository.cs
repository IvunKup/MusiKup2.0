using MusiKup.Application.Interfases;
using MusiKup.Domain.Entities.Files;
using MusiKup.Infrastructure.Dal.EntityFramework;

namespace MusiKup.Infrastructure.Dal.Repositories;

public class TrackFileRepository : Repository<TrackFile>, IRepository<TrackFile>
{
    public TrackFileRepository(MusiKupContext dbContext) : base(dbContext)
    {
    }
}