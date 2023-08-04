using LaundrySimulator2.Classes;
using Microsoft.EntityFrameworkCore;

namespace LaundrySimulator2
{

    public class Program2
    {
        static void Main(string[] args) //for now this is the beginning of my new main loop
        {
            Console.Title = "Laundry Simulator Redux";

            //MainMenu MainMenu = new MainMenu(); //calls MainMenu.cs ***REMOVE IF THIS WORKS IN MAIN LOOP BELOW***

            using var db = new LaundrySimulatorReduxContext(); //look into this to see  if i need to change this 

            //using (NameContext context = new NameContext()) **may keep this since its just a console application***
            //{
            //    context.Database.EnsureCreated();
            //}

            //GetPlayerName();
            //Thread.Sleep(100);
            //Console.Clear();
            MainLoop();
            //DefaultInvTest();

            void GetPlayerName() // this will eventually be moved into its own class or file
            {
                Console.WriteLine("What is your name?");
                var player = new PlayerName { Name = Console.ReadLine()}; //add a if block in case someone doesn't enter anything!
                using var context = new LaundrySimulatorReduxContext();
                context.PlayerNames.Add(player);                
                Console.WriteLine("Thank you, " + player.Name); //eventually update with more of tone i am wanting
                context.SaveChanges();             
            }

            void DefaultInvTest() //DON'T FORGET TO REFACTOR METHOD AND CHANGE TO REFLECT THE PLAYER INVENTORY
            {
                Console.WriteLine("This is a test to see if the Default Inventory table appears"); // DON'T FORGET TO CHANGE 
                using var context = new LaundrySimulatorReduxContext();
                var defaultinv = context.DefaultInventories; //CHANGE defaultinv to appropriate table name from lines 42 to 45!
                foreach (var defaultInventories in defaultinv)
                {
                    Console.WriteLine(defaultInventories);
                }
            }

            void MainLoop()
            {
                MainMenu mainMenu = new MainMenu(); //don't forget to clean up MainMenu
                Intro();
                GetPlayerName();


            }

            void Intro()
            {
                Console.WriteLine("Finally home from work, you stumble into the door, elated. You toss your keys and other personal items in a corner somewhere, kick your shoes off like Kevin Bacon and head toward your bedroom. Your bed is looking inviting. Calling your name. Before you can give your bed a hug is when you see it...\n\n\n");
                Thread.Sleep(3000); //look for better alternative such as delay or await
                Console.WriteLine("Your dirty laundry in the corner! 'Could this day get any worse...', You think to yourself as your begrudgingly drag yourself to all your laundry and grab it, grab your laundry detergent and wallet (after searching for it since you tossed it and headed toward your apartment's laundry area....\n\n\n");
                Thread.Sleep(3000);
                Console.WriteLine("However... you weren't prepared for what awaited you...");
                Thread.Sleep(1000);
                Console.WriteLine("Press any key to continue.");
                Console.ReadKey();
            }


            //***GAME LOOP WILL PROCEED HERE***

            //this is where the player name will be asked and put in a table
            //figure out how to pick up what was chosen in mainmenu and go from there if ()

            //-------------------------------BELOW IS PSEUDO CODE------------------------------------

            //bool showMenu = true;
            //while (true)
            //{
            //    showMenu = Menu2();
            //}
        }
        //    //pseudo code onward
        //    show title
        //    wait a few seconds

        //    call the mainMenu //mainMenu will a class of some kind
        //    after selection, display whatever corresponds with option chosen
        //    to know what to do have a SWITCH block that will call the requested output  //playing the game, instruction, quitting, etc will be the outputs

        //    when mainMenu is finished, bring forth appropriate menu such as GamePlayMenu

        //}
    }
}