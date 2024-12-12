using Microsoft.EntityFrameworkCore;
using MusiKup.Application.Interfases;
using MusiKup.Domain.Entities;

namespace MusiKup.Infrastructure.Dal.Repositories;

public class PlaylistRepository : Repository<Playlist>, IRepository<Playlist>
{
    protected PlaylistRepository(DbContext dbContext) : base(dbContext)
    {
    }
}