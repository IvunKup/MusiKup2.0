using MusiKup.Application.Interfases;
using MusiKup.Domain.Entities;
using MusiKup.Infrastructure.Dal.EntityFramework;

namespace MusiKup.Infrastructure.Dal.Repositories;

public class PlaylistRepository : Repository<Playlist>, IRepository<Playlist>
{
    public PlaylistRepository(MusiKupContext dbContext) : base(dbContext)
    {
    }
}