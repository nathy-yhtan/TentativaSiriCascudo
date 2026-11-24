using Microsoft.EntityFrameworkCore;
using MySqlConnector;
using TentativaSiriCascudo.Data;
using TentativaSiriCascudo.Repositories;
using TentativaSiriCascudo.Services;

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


//❗INJEÇÕES (uma p/ cada repository) DE DEPENDÊNCIA❗

builder.Services.AddScoped<IFornecedorRepository, FornecedorRepository>();
builder.Services.AddScoped<IInfonutriRepository, InfonutriRepository>();
builder.Services.AddScoped<IPedidoRepository, PedidoRepository>();
builder.Services.AddScoped<IItenspedidoRepository, ItenspedidoRepository>();
builder.Services.AddScoped<IProdutoRepository, ProdutoRepository>();

//❗REGISTRO DOS SERVIÇOS❗

builder.Services.AddScoped<IInfonutriService, InfonutriService>();
builder.Services.AddScoped<IFornecedorService, FornecedorService>();
builder.Services.AddScoped<IPedidoService, PedidoService>();
builder.Services.AddScoped<IItenspedidoService, ItenspedidoService>();
builder.Services.AddScoped<IProdutoService, ProdutoService>();



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