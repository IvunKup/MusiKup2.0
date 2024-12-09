using Microsoft.EntityFrameworkCore;
using MusiKup.Application.Interfases;
using MusiKup.Domain.Entities.Files;

namespace MusiKup.Infrastructure.Dal.Repositories;

public class PerformerFileRepasitory : Repository<PerformerFile>, IRepository<PerformerFile>
{
    protected PerformerFileRepasitory(DbContext dbContext) : base(dbContext)
    {
    }
}