using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MusiKup.Domain.Entities.Files;

namespace MusiKup.Infrastructure.Dal.EntityFramework.Configurations;

public class AuthorFileConfiguration : IEntityTypeConfiguration<AuthorFile>
{
    public void Configure(EntityTypeBuilder<AuthorFile> builder)
    {
        builder.HasOne(af => af.Author)
            .WithMany(af => af.AuthorFiles)
            .HasForeignKey(af => af.AuthorId);
    }
}