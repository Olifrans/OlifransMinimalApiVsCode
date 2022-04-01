using OlifransMinimalApiVsCode.Endpoints;
using OlifransMinimalApiVsCode.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Persistência do DB
builder.AddPersistence();


var app = builder.Build();

//Endpoints
app.MapEndpointsTarefas();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();


app.Run();
