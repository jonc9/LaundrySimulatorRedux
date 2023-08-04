To run this application is quite simple. I wanted to have it where you could just run it and didn't need to do any 
of the InitialCreate and so on but I didn't have the time to implement it the way I wanted.

So, run the InitialCreate migration then Update-Database in the Package Manager Console. If you haven't done so
install the Microsoft.EntityFrameworkCore.SqlServer & Microsoft.EntityFrameworkCore.Tools Nuget packages first. EF Core 7
is the version I am using.

This should be all you need to do to get the database to be created.

After that when you run the program you should be prompted with the title, a little intro and then the main menu
with three options to choose from.

Choosing option 1 will take you to the gameplay itself, option 2 is an how to play / about, option 3 is to exit the
application.


With option 1 you will be given a bit more story text, see your inventory, then enter your name and due to my time
constraints and difficulties I had, I had to alter what I wanted to really do to just a simple yes/no question 
for the player to respond to in order to at least complete the gameloop itself.



