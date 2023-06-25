using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaundrySimulator2.Menus //more pseudocode
{
    public class MainMenu  //will there be a 'default menu' to be inherited
    {
        //these will accept user input of 1, 2 or 3 and so on. will use a .tolower() or an int.TryParse() as well to account for options entered numerically or with letters
        show first option -- "Play game?"
        show second option -- "how to play?"
        third option -- "quit"
    }

    //for now going to put other class ideas in this file and will split up later if needed

    public class GameplayMenu //this will be the menu that always shows up after player input, resulting output
    {
        display input option 1 //these options may change (preferably) based on the last selection made
        display input option 2
        display input option 3
        ...and so on //one option will always have to be quit/exit. 
          
        check the databases to make sure theyre up-to-date after each action // may be able to use asynchronous programming here as a feature?
            // was going to start my pseudocode for player. was thinking it would do checks of the inventories and be called during the main loop with each 'turn'
    }
}
