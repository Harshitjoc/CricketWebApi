using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Cricket.Data;
using Cricket.Data.Repositories;
using Cricket.Models;
using Cricket.Data.Models;
using Cricket.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<CricketContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("CricketContext") ?? throw new InvalidOperationException("Connection string 'CricketContext' not found.")), ServiceLifetime.Transient);

builder.Services.AddScoped<IGenericRepository<BatsmanScoreBoard>, BatsmanScoreBoardRepository>();
builder.Services.AddScoped<IGenericRepository<BowlerScoreBoard>, BowlerScoreBoardRepository>();
builder.Services.AddScoped<IGenericRepository<PlayerRoleMap>, PlayerRoleMapRepository>();
builder.Services.AddScoped<IGenericRepository<ScoreBoard>, ScoreBoardRepository>();
builder.Services.AddScoped<IGenericRepository<Team>, TeamRepository>();
builder.Services.AddScoped<IGenericRepository<TeamPlayerMap>, TeamPlayerMapRepository>();
builder.Services.AddScoped<IGenericRepository<UmpireRoleMap>, UmpireRoleMapRepository>();
builder.Services.AddScoped<IGenericRepository<Player>, PlayerRepository>();
builder.Services.AddScoped<IGenericRepository<Country>, CountryRepository>();
builder.Services.AddScoped<IGenericRepository<MatchDetail>, MatchDetailRepository>();
builder.Services.AddScoped<IGenericRepository<PlayerRole>, PlayerRoleRepository>();
builder.Services.AddScoped<IGenericRepository<Series>, SeriesRepository>();
builder.Services.AddScoped<IGenericRepository<Stadium>, StadiumRepository>();
builder.Services.AddScoped<IGenericRepository<Umpire>, UmpireRepository>();
builder.Services.AddScoped<IGenericRepository<UmpireRole>, UmpireRoleRepository>();


builder.Services.AddScoped<IBatsmanScoreBoardService , BatsmanScoreBoardService>();
builder.Services.AddScoped<IBowlerScoreBoardService , BowlerScoreBoardService>();
builder.Services.AddScoped<IPlayerRoleMapService, PlayerRoleMapService>();
builder.Services.AddScoped<IScoreBoardService, ScoreBoardService>();
builder.Services.AddScoped<ITeamService, TeamService>();
builder.Services.AddScoped<ITeamPlayerMapService, TeamPlayerMapService>();
builder.Services.AddScoped<IUmpireRoleMapService, UmpireRoleMapService>();
builder.Services.AddScoped<IPlayerService, PlayerService>();
builder.Services.AddScoped<ICountryService, CountryService>();
builder.Services.AddScoped<IMatchDetailService, MatchDetailService>();
builder.Services.AddScoped<IPlayerRoleService, PlayerRoleService>();
builder.Services.AddScoped<ISeriesService, SeriesService>();
builder.Services.AddScoped<IStadiumService, StadiumService>();
builder.Services.AddScoped<IUmpireService, UmpireService>();
builder.Services.AddScoped<IUmpireRoleService, UmpireRoleService>();


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

