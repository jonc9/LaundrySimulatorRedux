using Microsoft.EntityFrameworkCore;

namespace LaundrySimulator2
{
    public class PlayerName //this is what gets the player name and stores it
    {
        public int Id { get; set; }
        public required string Name { get; set; }
    }
}