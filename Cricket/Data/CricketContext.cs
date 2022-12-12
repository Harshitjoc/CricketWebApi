using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Cricket.Models;


namespace Cricket.Data
{
    public class CricketContext : DbContext
    {
        public CricketContext (DbContextOptions<CricketContext> options)
            : base(options)
        {
        }

        public DbSet<Country> Country { get; set; } = default!;

        public DbSet<MatchDetail> MatchDetail { get; set; }

        public DbSet<Player> Player { get; set; }

        public DbSet<PlayerRole> PlayerRole { get; set; }

        public DbSet<Series> Series { get; set; }

        public DbSet<Stadium> Stadium { get; set; }

        public DbSet<Toss> Toss { get; set; }

        public DbSet<Umpire> Umpire { get; set; }

        public DbSet<UmpireRole> UmpireRole { get; set; }

        public DbSet<Cricket.Models.BatsmanScoreBoard> BatsmanScoreBoard { get; set; }

        public DbSet<Cricket.Models.BowlerScoreBoard> BowlerScoreBoard { get; set; }

        public DbSet<Cricket.Models.PlayerRoleMap> PlayerRoleMap { get; set; }

        public DbSet<Cricket.Models.ScoreBoard> ScoreBoard { get; set; }

        public DbSet<Cricket.Models.Team> Team { get; set; }

        public DbSet<Cricket.Models.TeamPlayerMap> TeamPlayerMap { get; set; }

        public DbSet<Cricket.Models.UmpireRoleMap> UmpireRoleMap { get; set; }
    }
}
