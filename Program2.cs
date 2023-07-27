namespace LaundrySimulator2
{
    public class Program2
    {
        static void Main(string[] args) //for now this is the beginning of my new main loop
        {
            Console.Title = "Laundry Simulator Redux";

            MainMenu MainMenu = new MainMenu();

            using var db = new NameContext(); //look into this to see  if i need to change this 

            //this is where the player name will be asked and put in a table
            Console.WriteLine("What is your name?");
            db.Add(new PlayerName { });
            db.SaveChanges();

            //figure out how to pick up what was chosen in mainmenu and go from there if ()
            //{

            //}




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