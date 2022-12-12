using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Cricket.Data;
using Cricket.Data.Repositories;
using Cricket.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<CricketContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("CricketContext") ?? throw new InvalidOperationException("Connection string 'CricketContext' not found.")));
builder.Services.AddScoped<IGenericRepository<Player>, PlayerRepository>();
builder.Services.AddScoped<IGenericRepository<Country>, CountryRepository>();
builder.Services.AddScoped<IGenericRepository<MatchDetail>, MatchDetailRepository>();
builder.Services.AddScoped<IGenericRepository<PlayerRole>, PlayerRoleRepository>();
builder.Services.AddScoped<IGenericRepository<Series>, SeriesRepository>();
builder.Services.AddScoped<IGenericRepository<Stadium>, StadiumRepository>();
builder.Services.AddScoped<IGenericRepository<Toss>, TossRepository>();
builder.Services.AddScoped<IGenericRepository<Umpire>, UmpireRepository>();
builder.Services.AddScoped<IGenericRepository<UmpireRole>, UmpireRoleRepository>();


// Add services to the container.

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

