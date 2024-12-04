using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MusiKup.Domain.Entities;

namespace MusiKup.Infrastructure.Dal.EntityFramework.Configurations;

public class PlaylistConfiguretion : IEntityTypeConfiguration<Playlist>
{
    public void Configure(EntityTypeBuilder<Playlist> builder)
    {
        builder.HasKey(p => p.Id);

        builder.Property(p => p.Title)
            .HasMaxLength(100)
            .IsRequired();

        builder.Property(p => p.Description)
            .HasMaxLength(1000)
            .IsRequired();

        builder.HasMany(p => p.Tracks)
            .WithMany(p => p.Playlists);

        builder.HasMany(p => p.PlaylistFiles)
            .WithOne(p => p.Playlist)
            .HasForeignKey(p => p.PlaylistId);
    }
}