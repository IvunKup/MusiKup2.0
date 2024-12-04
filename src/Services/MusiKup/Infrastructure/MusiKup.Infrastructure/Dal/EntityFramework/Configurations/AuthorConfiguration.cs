using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MusiKup.Domain.Entities;

namespace MusiKup.Infrastructure.Dal.EntityFramework.Configurations;

public class AuthorConfiguration : IEntityTypeConfiguration<Author>
{
    public void Configure(EntityTypeBuilder<Author> builder)
    {
        builder.HasKey(a => a.Id);

        builder.Property(a => a.NickName)
            .HasMaxLength(100)
            .IsRequired();

        builder.OwnsOne(a => a.FullName, a =>
        {
            a.Property(f => f.FirstName)
                .HasMaxLength(50)
                .IsRequired();

            a.Property(f => f.LastName)
                .HasMaxLength(50)
                .IsRequired();

            a.Property(f => f.MiddleName)
                .HasMaxLength(50);
        });

        builder.HasMany(a => a.Tracks)
            .WithOne(a => a.Author)
            .HasForeignKey(a => a.AuthorId)
            .IsRequired();

        builder.HasMany(a => a.AuthorFiles)
            .WithOne(a => a.Author)
            .HasForeignKey(a => a.AuthorId)
            .IsRequired();
    }
}