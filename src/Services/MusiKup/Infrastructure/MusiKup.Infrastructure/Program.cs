using Google.Cloud.Storage.V1;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using MusiKup.Application.Interfases;
using MusiKup.Application.Services;
using MusiKup.Application.Settings;
using MusiKup.Domain.Entities;
using MusiKup.Infrastructure.Dal.EntityFramework;
using MusiKup.Infrastructure.Dal.Repositories;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<MusiKupContext>(opt => opt.UseNpgsql(builder.Configuration.GetConnectionString("MusiKup")));
builder.Services.AddTransient<AuthorService>();
builder.Services.AddTransient<PerformerService>();
builder.Services.AddTransient<PlaylistService>();
builder.Services.AddTransient<TrackService>();
builder.Services.AddTransient<AuthorFileService>();
builder.Services.AddTransient<PerformerFileService>();
builder.Services.AddTransient<PlaylistFileService>();
builder.Services.AddTransient<TrackFileService>();
builder.Services.AddTransient<UserFileService>();
builder.Services.AddTransient<IRepository<Author>, AuthorRepository>();
builder.Services.AddTransient<IRepository<Performer>, PerformerRepository>();
builder.Services.AddTransient<IRepository<Playlist>, PlaylistRepository>();
builder.Services.AddTransient<IRepository<Track>, TrackRepository>();

builder.Services.AddTransient<StorageClient>(provider =>
{
    var settings = provider.GetRequiredService<IOptions<GoogleSettings>>().Value;

    var googleCredential =
        Google.Apis.Auth.OAuth2.GoogleCredential.FromFile(Path.Combine(Directory.GetCurrentDirectory(),
            settings.FileName));

    return StorageClient.Create(googleCredential);
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

