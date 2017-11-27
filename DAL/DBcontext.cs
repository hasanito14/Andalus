using BOL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class LeagueContext : DbContext
    {
        public LeagueContext() : base("LeagueDb")
        {
            Configuration.ProxyCreationEnabled = false;
        }

        public DbSet<Player> Players { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Team> Teams { get; set; }

    }

}
