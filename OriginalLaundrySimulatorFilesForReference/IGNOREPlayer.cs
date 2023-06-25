/*using System;
using System.Collections.Generic;
using System.Linq; //may not need?
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LaundrySimulator
{
    private class Player : Inventory
    {
        public string name { get; set; }
        
        public void PlayerName(string n)
        {
            name = n;            
        }

        public void inputCall()
        {
            Console.WriteLine("What is your name?");
            name = Console.ReadLine();
            Console.ReadLine();
            Console.WriteLine("\nThank you, " + name);

        }

    }
    public class playerName
    {
        public string name { get; set; }
    }

}

/*public Player(string name)
{ 
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new ArgumentException($"'{nameof(name)}' cannot be null or whitespace.", nameof(name));
        }

        this.name = name;
    }
}*/
