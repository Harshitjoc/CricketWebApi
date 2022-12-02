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

        public DbSet<TeamA> TeamA { get; set; }

        public DbSet<TeamB> TeamB { get; set; }

        public DbSet<Toss> Toss { get; set; }

        public DbSet<Umpire> Umpire { get; set; }

        public DbSet<UmpireRole> UmpireRole { get; set; }
    }
}
