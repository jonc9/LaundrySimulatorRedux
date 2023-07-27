using Microsoft.EntityFrameworkCore;

namespace LaundrySimulator2
{
    public class NameContext : DbContext
    {
        public DbSet<PlayerNames> PlayerName { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = LaundrySimulatorReduxDataBase");
        }
    }

    public class PlayerName // will probably have to put this into its own file at some point
    {
        public int NameId { get; set; }
        public string Name { get; set; }
    }
}

