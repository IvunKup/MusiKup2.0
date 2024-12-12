using MusiKup.Application.Interfases;
using MusiKup.Domain.Entities.Files;
using MusiKup.Infrastructure.Dal.EntityFramework;

namespace MusiKup.Infrastructure.Dal.Repositories;

public class PlaylistFileRepository : Repository<PlaylistFile>, IRepository<PlaylistFile>
{
    public PlaylistFileRepository(MusiKupContext dbContext) : base(dbContext)
    {
    }
}