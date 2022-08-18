using Core.Validation;
using DAL;
using DAL.Repositories;
using DAL.Repositories.Abstract;
using Infrastructure.Models.CreateModels;
using Infrastructure.Services;
using Infrastructure.Services.Abstract;
using Infrastructure.Validations;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Host.ConfigureLogging(loggin =>
{
    loggin.ClearProviders();
    loggin.AddConsole();
});
// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<OutdoorContext>(x => x.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnectionStrings")));
builder.Services.AddScoped<INomenclatureService, NomenclatureService>();
builder.Services.AddScoped<IPlaceService, PlaceService>();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped<IAnimalRepository, AnimalRepository>();
builder.Services.AddScoped<IExtrasRepository, ExtrasRepository>();
builder.Services.AddScoped<ILakeRepositry, LakeRepository>();
builder.Services.AddScoped<IFountainRepository, FountainRepository>();
builder.Services.AddScoped<ILandmarkRepository, LandmarkRepository>();
builder.Services.AddScoped<INatureReserveRepository, NatureReserveRepository>();
builder.Services.AddScoped<IParkRepository, ParkRepository>();
builder.Services.AddScoped<IVillaRepository, VillaRepository>();
builder.Services.AddScoped<IWaterTypeRepository, WaterTypeRepository>();
builder.Services.AddScoped<IOutdoorRepository, OutdoorRepository>();
builder.Services.AddScoped<IValidation<CreateLakesModel>, CreateLakesModelValidator>();
builder.Services.AddScoped<IValidation<CreateFountainsModel>, CreateFountainsModelValidator>();

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
