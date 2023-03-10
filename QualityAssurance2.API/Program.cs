using AyubArbievQualityAssurance2.Data.Models.Entities;
using Microsoft.EntityFrameworkCore;
using QualityAssurance2.API;
using QualityAssurance2.Data.DataBase.SqlServer;
using QualityAssurance2.Data.Repositories.Implementations;
using QualityAssurance2.Data.Repositories.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddTransient<IRepository<Order>, Repository<Order>>();

var connection = builder.Configuration.GetConnectionString("ConnectionString2");

builder.Services.AddDbContext<AppDbContext>(option => option.UseSqlServer(connection));
builder.Services.InitializeRepositories();
builder.Services.InitializeServeces();

builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));


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
