using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MusiKup.Domain.Entities.Files;

namespace MusiKup.Infrastructure.Dal.EntityFramework.Configurations;

public class TrackFileConfiguration : IEntityTypeConfiguration<TrackFile>
{
    public void Configure(EntityTypeBuilder<TrackFile> builder)
    {
        builder.HasOne(tf => tf.Track)
            .WithMany(tf => tf.TrackFiles)
            .HasForeignKey(tf => tf.TrackId);
    }
}