using System.ComponentModel;
using Microsoft.EntityFrameworkCore;

namespace LaundrySimulator2
{
    public class LaundrySimulatorReduxContext : DbContext
    {
        public DbSet<PlayerName> PlayerNames { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = LaundrySimulatorReduxDataBase");
        }
    }
}

