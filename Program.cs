using MyCrudApi.Domain.Configuration;

var builder = WebApplication.CreateBuilder(args);

builder.Services.ConfigureInfrastructureDependencies();
builder.Services.ConfigureDomainDependencies();

builder.Services.AddConnections(builder.Configuration);

// Adicionando controladores e outras depend�ncias
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
