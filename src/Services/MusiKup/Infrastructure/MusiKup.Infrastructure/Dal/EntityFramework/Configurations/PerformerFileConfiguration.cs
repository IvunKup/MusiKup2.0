using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MusiKup.Domain.Entities.Files;

namespace MusiKup.Infrastructure.Dal.EntityFramework.Configurations;

public class PerformerFileConfiguration : IEntityTypeConfiguration<PerformerFile>
{
    public void Configure(EntityTypeBuilder<PerformerFile> builder)
    {
        builder.HasOne(pf => pf.Performer)
            .WithMany(pf => pf.PerformerFiles)
            .HasForeignKey(pf => pf.PerformerId)
            .IsRequired();
    }
}