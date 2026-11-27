using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi;
using MySqlConnector;
using System.Text;
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

//❗CONFIGURAÇÃO DO JWT❗

var key = Encoding.ASCII.GetBytes(builder.Configuration["Jwt:Key"]);

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuerSigningKey = true, //verifica se o token foi assinado corretamente
            IssuerSigningKey = new SymmetricSecurityKey(key), //usa a chave secreta para validar o token
            ValidateIssuer = true, //valida qm cirou o token
            ValidIssuer = builder.Configuration["Jwt:Issuer"],
            ValidateAudience = true, //valida para qm o token foi criado
            ValidAudience = builder.Configuration["Jwt:Audience"]
        }; 
    });

//❗CONFIGURAÇÃO DO BOTÃO NO SWAGGER❗

builder.Services.AddSwaggerGen(c=>
{
    //criar o botao uthorize no swagger
    c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme)
    {
        Name="Authorizatiom"
    }
}



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