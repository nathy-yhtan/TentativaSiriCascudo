var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();


//❗IMPORTANDO COISA NOVA❗

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen();


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