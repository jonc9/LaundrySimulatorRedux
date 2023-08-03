using LaundrySimulator2.Classes;

namespace LaundrySimulator2
{

    public class Program2
    {
        static void Main(string[] args) //for now this is the beginning of my new main loop
        {
            Console.Title = "Laundry Simulator Redux";

            MainMenu MainMenu = new MainMenu(); //calls MainMenu.cs

            using var db = new LaundrySimulatorReduxContext(); //look into this to see  if i need to change this 
            
            //using (NameContext context = new NameContext()) **may keep this since its just a console application***
            //{
            //    context.Database.EnsureCreated();
            //}

            GetPlayerName();
            Thread.Sleep(100);
            Console.Clear();

            DefaultInvTest();

            void GetPlayerName() // this will eventually be moved into its own class or file
            {
                Console.WriteLine("What is your name?");
                var player = new PlayerName { Name = Console.ReadLine()}; //add a if block in case someone doesn't enter anything!
                using var context = new LaundrySimulatorReduxContext();
                context.PlayerNames.Add(player);                
                Console.WriteLine("Thank you, " + player.Name); //eventually update with more of tone i am wanting
                context.SaveChanges();             
            }
            
            void DefaultInvTest() //***FIGURE OUT HOW TO GET THE SEEDED TABLE TO DISPLAY ON COMMAND***
            {
                Console.WriteLine("This is a test to see if the Default Inventory table appears");

                using (var context = new LaundrySimulatorReduxContext()) ;
                {
                    var DefaultInventory = context.DefaultInventories.ToList();
                }
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