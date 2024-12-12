using Google.Cloud.Storage.V1;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;
using MusiKup.Application.Interfases;
using MusiKup.Application.Services;
using MusiKup.Domain.Entities;
using MusiKup.Infrastructure.Dal.EntityFramework;
using MusiKup.Infrastructure.Dal.Repositories;
using MusiKup.Infrastructure.Settings;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddAuthentication();

builder.Services.AddAuthorization();

builder.Services.Configure<GoogleSettings>(builder.Configuration.GetSection(nameof(GoogleSettings)));

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.Configure<IdentityOptions>(options =>
{
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequireUppercase = true;
    options.Password.RequireDigit = true;
    options.Password.RequiredLength = 6;
    options.Password.RequiredUniqueChars = 1;
    options.Password.RequireLowercase = true;
    options.SignIn.RequireConfirmedEmail = false;
    options.SignIn.RequireConfirmedPhoneNumber = false;
    options.SignIn.RequireConfirmedAccount = false;
    options.User.RequireUniqueEmail = true;
});
builder.Services.AddSwaggerGen(opt =>
{
    opt.SwaggerDoc("v1", new OpenApiInfo { Title = "ExamApi", Version = "v1" });
    opt.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        In = ParameterLocation.Header,
        Description = "Please enter token",
        Name = "Authorization",
        Type = SecuritySchemeType.Http,
        BearerFormat = "JWT",
        Scheme = "bearer"
    });
    opt.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type = ReferenceType.SecurityScheme,
                    Id = "Bearer"
                }
            },
            Array.Empty<string>()
        }
    });
});
builder.Services.AddDbContext<MusiKupContext>
    (opt => opt.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<AuthorService>();
builder.Services.AddScoped<PerformerService>();
builder.Services.AddScoped<PlaylistService>();
builder.Services.AddScoped<TrackService>();

builder.Services.AddScoped<IRepository<Author>, AuthorRepository>();
builder.Services.AddScoped<IRepository<Performer>, PerformerRepository>();
builder.Services.AddScoped<IRepository<Playlist>, PlaylistRepository>();
builder.Services.AddScoped<IRepository<Track>, TrackRepository>();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

builder.Services.AddTransient<StorageClient>(provider =>
{
    var settings = provider.GetRequiredService<IOptions<GoogleSettings>>().Value;

    var googleCredential =
        Google.Apis.Auth.OAuth2.GoogleCredential.FromFile(Path.Combine(Directory.GetCurrentDirectory(),
            settings.FileName));

    return StorageClient.Create(googleCredential);
});

builder.Services.AddIdentityApiEndpoints<User>()
    .AddEntityFrameworkStores<MusiKupContext>();


var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();
app.UseAuthentication();

app.MapGroup("api/auth")
    .MapIdentityApi<User>();
app.MapControllers();

app.Run();
