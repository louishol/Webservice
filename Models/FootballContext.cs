using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Webserives.Models
{
    public class FootballContext : DbContext
    {
        public FootballContext() : base("FootballContext")
        {
        }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Competition> Competitions { get; set; }

    }
}