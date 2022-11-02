using ModuloAPI.Context;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
/*
    aqui nos estamos dizendo para o builder adicionar um DbContext do tipo AgendaContext,
    e passando algumas opções, dizendo para usar SqlServer, e passando a connextion string
    (caminho para acessar o banco de dados e como fazer login) que está no appsettings.json
    ou appsettings.Development.json.
    Daria para colocar a conection string direto aqui, mas se um dia precisar mudar teria que
    recompilar o codigo, e estando la no json ele vai estar junto com o programa compilado e ai
    é mais facil alterar.
 */
builder.Services.AddDbContext<AgendaContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ConexaoPadrao")));

//----------------------------------------

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
