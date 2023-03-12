using Microsoft.EntityFrameworkCore;
using QualityAssurance2.API;
using QualityAssurance2.Data.DataBase.SqlServer;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//builder.Services.AddTransient<IRepository<Order>, Repository<Order>>();

var connection = builder.Configuration.GetConnectionString("ConnectionString2");

builder.Services.AddDbContext<AppDbContext>(option => option.UseSqlServer(connection));
builder.Services.InitializeRepositories();
builder.Services.InitializeServeces();



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
