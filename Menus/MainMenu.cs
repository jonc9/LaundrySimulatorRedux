namespace LaundrySimulator2 //more pseudocode
{
    public class MainMenu //will there be a 'default menu' to be inherited
    {
        public MainMenu()
        {
            Console.WriteLine("\n");
            Console.WriteLine("Make your choice by entering a numerical digit. Nothing more.");
            Console.WriteLine("\n");

            Console.WriteLine("1.) Do Your Laundry"); // will link to the main gameplay loop
            Console.WriteLine("\n");

            Console.WriteLine("2.) About/How to play");
            Console.WriteLine("\n");

            Console.WriteLine("3.) Exit aka Give up on wearing clean clothes tomorrow.");
            Console.WriteLine("\n");
            var MainMenuInput = Console.ReadLine();

            switch(MainMenuInput)
            {
                case "1": //update for redux
                    Console.WriteLine("Okay. It is laundry time!");
                    Console.WriteLine("\n");
                    Console.WriteLine("Here are the clothes you find in your laundry basket:" + "\n");
                    Thread.Sleep(1000);
                    break;

                case "2": //don't forget to update
                    Console.WriteLine("This is a version of a silly idea I had I wanted to do for my final project. However, what I wanted to do " +
                "was going to take longer than ancitipated... This version you have limited options as to what you can do. The README will " +
                "have more information." + "\n");
                    Thread.Sleep(2000); //implement a 'wait' and a "goback selection" use ClearConsole as well?
                    break;                                     //Console.ReadKey(); -- this may be used to have the program wait until a key is pressed to go back?


                case "3":
                    Console.WriteLine("\n" + "I guess this is goodbye. Have fun being smelly!");
                    Thread.Sleep(3000);
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Try again, please.");
                    Console.Clear();
                    break;
            }
        }
    }
}
    //public static bool Menu2()
    //{
    //    Console.Clear();
    //    Console.WriteLine("choose 1");
    //    Console.ReadLine();

//    switch (Console.ReadLine())
//    {
//        case "1":
//            // Console.WriteLine("hi there");
//            return true;
//    }
//}