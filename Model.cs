using Microsoft.EntityFrameworkCore;

namespace LaundrySimulator2
{
    public class NameContext : DbContext
    {
        public DbSet<PlayerNames> PlayerName { get; set; }
    }

    public class PlayerName
    {
        public int NameId { get; set; }
    }
}

