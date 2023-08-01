﻿using System.ComponentModel.DataAnnotations;

namespace LaundrySimulator2
{
    public class PlayerName : NameContext
    {
        [Key]
        public int NameId { get; set; } // 7-26-2023: NEED TO HAVE THIS BE USED TO ACCEPT USER INPUT FOR THE NAME.
        public string Name { get; set; }
    }
}