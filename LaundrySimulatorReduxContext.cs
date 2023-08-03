using Microsoft.EntityFrameworkCore;

namespace LaundrySimulator2
{
    public class LaundrySimulatorReduxContext : DbContext //***ADD METHOD FOR SETTING UP INITIAL MIGRATION AS SOON AS APPLICATION STARTS***
    {
        public DbSet<PlayerName> PlayerNames { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = LaundrySimulatorReduxDataBase");
        }

        public DbSet<DefaultInventory> DefaultInventories { get; set; }

        public class DefaultInventory // This is the class to set what the default (aka all possible items) has. *** may eventually convert to Interface***
        {
            public int InvId { get; set; }
            public required string ItemName { get; set; }
            public string ItemDescription { get; set; }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder) //this is for seeding
        {
            modelBuilder.Entity<DefaultInventory>()
                .ToTable("DefaultInventory");
            modelBuilder.Entity<DefaultInventory>()
                .HasKey(i => i.InvId)
                .HasName("PrimaryKey_InvId");
            modelBuilder.Entity<DefaultInventory>()
                .Property(i => i.ItemName)
                .IsRequired(true);
            
            
            modelBuilder.Entity<DefaultInventory>().HasData(
                new DefaultInventory { InvId = 1, ItemName = "Mallet", ItemDescription = "Test description" }//update descriptions later
        );
        }
    }
}

