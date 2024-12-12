using Microsoft.EntityFrameworkCore;
using MusiKup.Application.Interfases;
using MusiKup.Domain.Entities.Files;

namespace MusiKup.Infrastructure.Dal.Repositories;

public class TrackFileRepository : Repository<TrackFile>, IRepository<TrackFile>
{
    protected TrackFileRepository(DbContext dbContext) : base(dbContext)
    {
    }
}