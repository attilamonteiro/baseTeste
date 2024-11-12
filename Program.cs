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

// Configura as dependências do repositório e do serviço
builder.Services.ConfigureInfrastructureDependencies();
builder.Services.ConfigureDomainDependencies();

// Adiciona conexões e outras dependências
builder.Services.AddConnections();

// Adiciona controladores e outras dependências
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configuração do Swagger e Middlewares
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
