using Microsoft.AspNetCore.Mvc;
using CrudClients.Applications;
using Microsoft.AspNetCore.Http.HttpResults;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
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

app.MapGet("/clientes", () =>
{
    return new Clientes().Obter(new Cliente());
})
.WithName("ObterClientes")
.WithOpenApi();

app.MapDelete("/remover", ([FromQuery] int id) =>
{
    return "";
})
.WithName("RemoverClientes")
.WithOpenApi();

app.MapPost("/cadastrar-clientes", ([FromBody] Cliente cliente) =>
{
    new Clientes().CadastrarAlteracoes(cliente);
    return new OkResult();
})
.WithName("CadastrarClientes")
.WithOpenApi();

app.Run();

