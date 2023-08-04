using LaundrySimulator2.Classes;
using Microsoft.EntityFrameworkCore;

namespace LaundrySimulator2
{
    public class LaundrySimulatorReduxContext : DbContext //***ADD METHOD FOR SETTING UP INITIAL MIGRATION AS SOON AS APPLICATION STARTS***
    {
        public DbSet<PlayerName> PlayerNames { get; set; }
        
        public DbSet<DefaultInventory> DefaultInventories { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = LaundrySimulatorReduxDataBase");
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
                new DefaultInventory { InvId = 1, ItemName = " - Laundry Detergent", ItemDescription = "Run of the mill variety detergent;" },
                new DefaultInventory { InvId = 2, ItemName = " - Wallet", ItemDescription = "Your wallet. Tearing at the seams. Only a couple quarters;" },
                new DefaultInventory { InvId = 3, ItemName = " - JNCO Jeans", ItemDescription = "Something from your youth. How did they get here?;" },
                new DefaultInventory { InvId = 4, ItemName = " - Sailor Moon T-shirt", ItemDescription = "Black t-shirt with Sailor Saturn on it since she's your favorite;" },
                new DefaultInventory { InvId = 5, ItemName = " - Polo shirt with your name on it.", ItemDescription = "Basic purple polo shirt you got as a gift;" }


                //new DefaultInventory { InvId = 100, ItemName = "Mallet", ItemDescription = "Test description" }//update descriptions later

        );
        }        
    }
}

