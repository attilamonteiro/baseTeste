using MyCrudApi.Services;
using Microsoft.EntityFrameworkCore;
using MyCrudApi.Data;

var builder = WebApplication.CreateBuilder(args);

// Configuração dos controladores e do Swagger para documentação da API
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Configuração do DbContext
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite("Data Source=ProductsDb.db")
           .EnableSensitiveDataLogging()
           .LogTo(Console.WriteLine, LogLevel.Information));

// Registra o ProductsService como um serviço escopo (scoped)
builder.Services.AddScoped<ProductsService>();

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
