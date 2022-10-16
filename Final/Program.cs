
using System;
public class game
{ public string player;
    public static void Main(String[] args);
    var aGame = new Game(Console.Out);
    List<int> gamequestionNumbers = new List<int>(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);
   

     aGame.Add("player1");
    aGame.Add("player2");
    aGame.Add("player3");

var random = new Random();

    Run(aGame, random);

Console.WriteLine("Welcome to Triviabate");

Console.WriteLine("How old are you?");
if (player <= 17)
    Console.WriteLine("You are not authorized to play this game.You must be 18 or older.");
else if player => 18
            Console.WriteLine("You're 18 or older let's get the party started!");
    else(player null)
    Console.WriteLine("No response was recieved please start over.");

Console.WriteLine("Choose a username! What would you like your username to be?");
     
{
    
   
}

}
