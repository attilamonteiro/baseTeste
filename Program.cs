using MyCrudApi.Configuration;

var builder = WebApplication.CreateBuilder(args);

builder.Services.ConfigureInfrastructureDependencies();
builder.Services.AddControllers();
builder.Services.AddConnections(builder.Configuration);

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
