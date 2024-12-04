using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MusiKup.Domain.Entities;

namespace MusiKup.Infrastructure.Dal.EntityFramework.Configurations;

public class TrackConfiguration : IEntityTypeConfiguration<Track>
{
    public void Configure(EntityTypeBuilder<Track> builder)
    {
        builder.HasKey(t => t.Id);

        builder.Property(t => t.Genre)
            .HasConversion<string>()
            .IsRequired();

        builder.Property(t => t.Title)
            .HasMaxLength(200)
            .IsRequired();

        builder.HasOne(t => t.Author)
            .WithMany(t => t.Tracks)
            .HasForeignKey(t => t.AuthorId);

        builder.HasOne(t => t.Performer)
            .WithMany(t => t.Tracks)
            .HasForeignKey(t => t.PerformerId);

        builder.HasMany(t => t.Playlists)
            .WithMany(t => t.Tracks);

        builder.HasMany(t => t.TrackFiles)
            .WithOne(t => t.Track)
            .HasForeignKey(t => t.TrackId);
    }
}