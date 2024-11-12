using MyCrudApi.Domain.Configuration;
using MyCrudApi.Infrastructure.Configuration;
using Microsoft.EntityFrameworkCore;
using MyCrudApi.Infrastructure.Contexts;

var builder = WebApplication.CreateBuilder(args);

// Registra o DbContext
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection"))
           .EnableSensitiveDataLogging()
           .LogTo(Console.WriteLine, LogLevel.Information));

// Configura as depend�ncias do reposit�rio e do servi�o
builder.Services.ConfigureInfrastructureDependencies();
builder.Services.ConfigureDomainDependencies();

// Adiciona conex�es e outras depend�ncias
builder.Services.AddConnections();

// Adiciona controladores e outras depend�ncias
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configura��o do Swagger e Middlewares
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
