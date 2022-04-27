using DAL;
using DAL.Repositories.Abstract;
using Infrastructure.Services.Abstract;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//builder.Services.AddDbContext<OutdoorContext>(x=>x.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnectionStrings"))
builder.Services.AddScoped<INomenclatureService, INomenclatureService>();
builder.Services.AddScoped<IAnimalRepository, IAnimalRepository>();

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
