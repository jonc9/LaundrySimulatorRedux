using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace LaundrySimulator2
{
    [PrimaryKey(nameof(NameId))]
    public class PlayerName
    {
        public int NameId { get; set; } // 7-26-2023: NEED TO HAVE THIS BE USED TO ACCEPT USER INPUT FOR THE NAME.
        public string Name { get; set; }
    }
}