using Microsoft.EntityFrameworkCore;

namespace LaundrySimulator2
{
    public class PlayerName
    {
        public int Id { get; set; } // 7-26-2023: NEED TO HAVE THIS BE USED TO ACCEPT USER INPUT FOR THE NAME.
        public required string Name { get; set; }
    }
}