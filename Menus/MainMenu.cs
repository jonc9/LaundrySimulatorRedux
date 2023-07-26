using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaundrySimulator2 //more pseudocode
{
    public class MainMenu //will there be a 'default menu' to be inherited
    {
        public static bool Menu2()
        {
            Console.Clear();
            Console.WriteLine("choose 1");
            Console.ReadLine();

            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("hi there");
                    return true;
            }
        }
    }
}