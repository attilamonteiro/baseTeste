using Microsoft.EntityFrameworkCore;  // Certifique-se de que esta linha está presente
using MyCrudApi.Data; // Ajuste para o seu namespace

var builder = WebApplication.CreateBuilder(args);

// Configuração do controlador e do Swagger para a documentação da API
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite("Data Source=ProductsDb.db")
           .EnableSensitiveDataLogging() // Para logs mais detalhados
           .LogTo(Console.WriteLine, LogLevel.Information)); // Para logar as queries no console


var app = builder.Build();

// Configuração do Swagger e dos Middlewares
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
