using Microsoft.EntityFrameworkCore;
using TentativaSiriCascudo.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();


//❗SWAGGER❗

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen();


//❗ENTITY❗

var connectionString = builder.Configuration.GetConnectionString("ConexaoPadrao");

builder.Services.AddDbContext<AppDbContext>(options =>
options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));


//❗TEM Q IMPORTAR ANTES DESSA VAR❗

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{ 
    app.MapOpenApi();


    //❗ADICIONANDO ❗
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();