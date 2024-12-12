using Microsoft.EntityFrameworkCore;
using MusiKup.Application.Interfases;
using MusiKup.Domain.Entities.Files;

namespace MusiKup.Infrastructure.Dal.Repositories;

public class PlaylistFileRepository : Repository<PlaylistFile>, IRepository<PlaylistFile>
{
    protected PlaylistFileRepository(DbContext dbContext) : base(dbContext)
    {
    }
}