using Microsoft.EntityFrameworkCore;
using MusiKup.Application.Interfases;
using MusiKup.Domain.Entities;

namespace MusiKup.Infrastructure.Dal.Repositories;

public class TrackRepository : Repository<Track>, IRepository<Track>
{
    protected TrackRepository(DbContext dbContext) : base(dbContext)
    {
    }
}