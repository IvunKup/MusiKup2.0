using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MusiKup.Domain.Entities.Files;

namespace MusiKup.Infrastructure.Dal.EntityFramework.Configurations;

public class BaseFileConfiguration : IEntityTypeConfiguration<BaseFile>
{
    public void Configure(EntityTypeBuilder<BaseFile> builder)
    {
        builder.HasKey(bf => bf.Id);

        builder.Property(bf => bf.FileName)
            .HasMaxLength(100)
            .IsRequired();

        builder.Property(bf => bf.FilePath)
            .IsRequired();

        builder.HasDiscriminator<string>("file_discriminator")
            .HasValue<TrackFile>(nameof(TrackFile))
            .HasValue<AuthorFile>(nameof(AuthorFile))
            .HasValue<PerformerFile>(nameof(PerformerFile))
            .HasValue<PlaylistFile>(nameof(PlaylistFile));
    }
}