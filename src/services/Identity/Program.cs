using System.Reflection;

using Identity.Data;
using Identity.Infrastructure.JWT;

using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options => {
    options.SwaggerDoc("v1", new OpenApiInfo {
        Version = "v1",
        Title = "Identity API",
        Description = "API для сервера авторизации и управления списком пользователей",
    });
    var xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFilename));
});

builder.Services.AddJwtAuthentication(
    new JwtAuthOptions {
        Issuer = builder.Configuration["Auth:iss"],
        Audience = builder.Configuration["Auth:aud"]

    });

builder.Services.AddAuthorization();

builder.Services.AddSingleton(_ => {
    var connectionString = builder.Configuration.GetConnectionString("IdentityDbContext");
    return new DbContextOptionsBuilder<IdentityDbContext>()
        .UseNpgsql(connectionString, o => { })
        .Options;
});

builder.Services.AddDbContext<IdentityDbContext>();
builder.Services.AddDbContextFactory<IdentityDbContext>();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();
app.UseAuthentication();

app.UseAuthorization();

app.Run();
