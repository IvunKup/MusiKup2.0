using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MusiKup.Domain.Entities;

namespace MusiKup.Infrastructure.Dal.EntityFramework.Configurations;

public class PerformerConfigurations : IEntityTypeConfiguration<Performer>
{
    public void Configure(EntityTypeBuilder<Performer> builder)
    {
        builder.HasKey(p => p.Id);

        builder.Property(p => p.NickName)
            .HasMaxLength(100)
            .IsRequired();

        builder.OwnsOne(p => p.FullName, p =>
        {
            p.Property(f => f.FirstName)
                .HasMaxLength(50)
                .IsRequired();

            p.Property(f => f.LastName)
                .HasMaxLength(50)
                .IsRequired();

            p.Property(f => f.MiddleName)
                .HasMaxLength(50);
        });

        builder.HasMany(p => p.Tracks)
            .WithOne(a => a.Performer)
            .HasForeignKey(a => a.PerformerId)
            .IsRequired();

        builder.HasMany(p => p.PerformerFiles)
            .WithOne(a => a.Performer)
            .HasForeignKey(a => a.PerformerId)
            .IsRequired();
    }
}