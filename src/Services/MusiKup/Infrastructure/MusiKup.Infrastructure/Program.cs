using Microsoft.EntityFrameworkCore;
using MusiKup.Application.Services;
using MusiKup.Infrastructure.Dal.EntityFramework;
using MusiKup.Infrastructure.Dal.Repositories;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<MusiKupContext>(opt => opt.UseNpgsql(builder.Configuration.GetConnectionString("MusiKup")));
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

builder.Services.AddTransient<AuthorService>();
builder.Services.AddTransient<PerformerService>();
builder.Services.AddTransient<PlaylistService>();
builder.Services.AddTransient<TrackService>();
builder.Services.AddTransient<AuthorFileService>();
builder.Services.AddTransient<PerformerFileService>();
builder.Services.AddTransient<PlaylistFileService>();
builder.Services.AddTransient<TrackFileService>();
builder.Services.AddTransient<UserFileService>();
builder.Services.AddTransient<AuthorRepository>();
builder.Services.AddTransient<PerformerRepository>();
builder.Services.AddTransient<PlaylistRepository>();
builder.Services.AddTransient<TrackRepository>();