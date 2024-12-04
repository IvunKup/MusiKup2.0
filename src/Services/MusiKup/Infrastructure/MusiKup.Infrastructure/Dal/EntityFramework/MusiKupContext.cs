using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MusiKup.Domain.Entities;
using MusiKup.Domain.Entities.Files;

namespace MusiKup.Infrastructure.Dal.EntityFramework;

public class MusiKupContext(DbContextOptions<MusiKupContext> options) : IdentityDbContext<User, IdentityRole<Guid>, Guid>(options)
{
    public DbSet<Author> Authors => Set<Author>();

    public DbSet<Performer> Performers => Set<Performer>();

    public DbSet<Playlist> Playlists => Set<Playlist>();

    public DbSet<Track> Tracks => Set<Track>();

    public DbSet<BaseFile> Files => Set<BaseFile>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(MusiKupContext).Assembly);
    }
}