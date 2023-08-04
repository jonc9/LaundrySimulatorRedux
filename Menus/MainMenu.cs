namespace LaundrySimulator2 //more pseudocode
{
    public class MainMenu //will there be a 'default menu' to be inherited? OR change this name to Menus and have methods for each type of menu below
    {
        public MainMenu()
        {
            topOfMenu:
            Console.WriteLine("\n");
            Console.WriteLine("Make your choice by entering a numerical digit.");
            Console.WriteLine("\n");

            Console.WriteLine("1.) Play!"); // will link to the main gameplay loop
            Console.WriteLine("\n");

            Console.WriteLine("2.) About/How to play");
            Console.WriteLine("\n");

            Console.WriteLine("3.) Exit");
            Console.WriteLine("\n");
            var MainMenuInput = Console.ReadLine();

            switch(MainMenuInput)
            {
                case "1": //
                    Console.WriteLine("Let's do this!");
                    Thread.Sleep(500);
                    Console.Clear();
                    break;

                case "2": //don't forget to update
                    Console.WriteLine("An updated version of my silly final project from my software development 1 course for Code Louisville. Just follow the on-screen prompts and you should be fine!");
                    Console.WriteLine("\nPress any key to go back to main menu.");
                    Console.ReadKey();
                    goto topOfMenu;

                case "3":
                    Console.WriteLine("\nOkay bye.");
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Try again, please.");
                    Console.WriteLine("\nPress any key to go back to main menu.");
                    Console.ReadKey();
                    Console.Clear();
                    break;
            }
        }
    }
}