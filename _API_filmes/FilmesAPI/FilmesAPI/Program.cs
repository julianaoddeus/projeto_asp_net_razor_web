using FilmesAPI.Data;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//adiciona este trecho ao MySQL SERVER
builder.Services.AddDbContext<FilmeContext>(opts => opts.UseMySQL(builder.Configuration.GetConnectionString("FilmeConnection")));
//Adiciona no MySQL
builder.Services.AddDbContext<FilmeContext>(opts => opts.UseMySQL(builder.Configuration.GetConnectionString("FilmeConnection")));

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
