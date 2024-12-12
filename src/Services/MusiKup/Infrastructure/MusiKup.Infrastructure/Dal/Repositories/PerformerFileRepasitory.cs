using MusiKup.Application.Interfases;
using MusiKup.Domain.Entities.Files;
using MusiKup.Infrastructure.Dal.EntityFramework;

namespace MusiKup.Infrastructure.Dal.Repositories;

public class PerformerFileRepasitory : Repository<PerformerFile>, IRepository<PerformerFile>
{
    public PerformerFileRepasitory(MusiKupContext dbContext) : base(dbContext)
    {
    }
}