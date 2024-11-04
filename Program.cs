using MyCrudApi.Services;
using Microsoft.EntityFrameworkCore;
using MyCrudApi.Data;

var builder = WebApplication.CreateBuilder(args);

// Configura��o dos controladores e do Swagger para documenta��o da API
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Configura��o do DbContext
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite("Data Source=ProductsDb.db")
           .EnableSensitiveDataLogging()
           .LogTo(Console.WriteLine, LogLevel.Information));

// Registra o ProductsService como um servi�o escopo (scoped)
builder.Services.AddScoped<ProductsService>();

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
