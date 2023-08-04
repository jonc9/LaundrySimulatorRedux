using LaundrySimulator2.Classes;
using Microsoft.EntityFrameworkCore;

namespace LaundrySimulator2
{

    public class Program2
    {
        static void Main(string[] args) //for now this is the beginning of my new main loop
        {
            Console.Title = "Laundry Simulator Redux";

            using var db = new LaundrySimulatorReduxContext(); //look into this to see  if i need to change this 


            MainLoop();

            //below are all the methods 

            void MainLoop()
            {
                Intro();
                TitleScreen();
                MainMenu mainMenu = new MainMenu(); //don't forget to clean up MainMenu
                GameLogic();
                Console.WriteLine("Thanks for playing!");
                Console.WriteLine("Press any key to exit.");
                Console.ReadKey();
                Environment.Exit(0);
            }

            void Intro() //an intro to set up a little story before the main menu appears
            {
                Console.WriteLine("Finally home from work, you stumble into the door, elated. You toss your keys and other personal items in a corner somewhere, kick your shoes off like Kevin Bacon and head toward your bedroom. Your bed is looking inviting. Calling your name. Before you can give your bed a hug is when you see it...\n\n\n");
                Thread.Sleep(3000); //look for better alternative such as delay or await
                Console.WriteLine("Your dirty laundry in the corner! 'Could this day get any worse...', You think to yourself as your begrudgingly drag yourself to all your laundry and grab it, grab your laundry detergent and wallet (after searching for it since you tossed it and headed toward your apartment's laundry area....\n\n\n");
                Thread.Sleep(3000);
                Console.WriteLine("However... you weren't prepared for what awaited you...");
                Thread.Sleep(1000);
                Console.WriteLine("Press any key to continue.\n");
                Console.ReadKey();
                Console.Clear();
            }

            void TitleScreen()
            {
                Console.WriteLine("LAUNDRY SIMULATOR V2 (new and improved forumla!)\n");
            }

            void GameLogic()
            {
                GamePlay();
            }


            void GetDefaultInv() // code for retrieving DefaultInventory table *DON'T FORGET TO REFACTOR METHOD*
            {
                using var context = new LaundrySimulatorReduxContext();
                var defaultinv = context.DefaultInventories;
                foreach (var defaultInventories in defaultinv)
                {
                    Console.WriteLine(defaultInventories);
                }
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }

            void GamePlay()
            {
                Console.WriteLine("Begrudgedly you make your way down the short hallway to the, what the apartment owners call, the laundry room, dragging your laundry basket behind you.\n");
                Console.WriteLine("Finally at the door to said laundry room you glance at your laundry basket to make sure all is accounted for:\n");
                GetDefaultInv();
                Console.WriteLine("You step inside and as you head to the washing machine you are stopped by someone else in there:");
                GetPlayerName();
                Console.WriteLine("\nAnnoyed you begin to reply, 'I don't think my name is-' before being cut off.\n");
                Console.WriteLine("It doesn't matter- nevermind. I will allow you to wash your clothes if answer this!");
                Console.WriteLine("\nYou don't even respond due to your being so tired.");
                NpcQuestion();
                Console.Clear();
                Console.WriteLine("After that the person disappeared in a puff of smoke like some magician. You stare bewildered for a moment or two, not really sure what just happened.");
                Console.WriteLine("Once you felt ready you stepped toward the washing machine and began throwing your clothes in there. Once finished you go to grab your wallet. It's no where to be found. You pause for a moment because you remember grabbing it before you left your apartment and then it hits you:");
                Thread.Sleep(2000);
                Console.WriteLine("\n\n\nThat person stole your wallet!");
            }

            void GetPlayerName() // this will eventually be moved into its own class or file
            {
                Console.WriteLine("You there! What is your name?");
                var player = new PlayerName { Name = Console.ReadLine() }; //add a if block in case someone doesn't enter anything!
                using var context = new LaundrySimulatorReduxContext();
                context.PlayerNames.Add(player);
                Console.WriteLine("Oh!" + player.Name + " is it? That's an odd name!"); //eventually update with more of tone i am wanting
                context.SaveChanges();
            }

            void NpcQuestion()
            {
                Console.WriteLine("\n\nWhat is the color of the polo you have in your laundry basket? No peeking! Choose between red, blue, purple, orange, black:");
                Console.ReadLine().ToLower();
                if (Console.ReadLine() == "purple")
                {
                    Console.WriteLine("You got it right! You may proceed!");
                }
                else
                {
                    Console.WriteLine("\nWrong but honeslty, I don't really care. Go ahead.");
                }
            }
        }
    }
}