using System;
namespace Final;

public class Program
{
    public static void Main(String[] args)
    {
        #region  Card Creating 
        var c1 = new Card
        {
            ID = 1,
            Category = " Sexual Health ",
            Question = "What is the most common STD/STI in the USA?",
            Answer = "Human papillomavirus (HPV)",
            Choices = new List<string>()
                {
                    "Human papillomavirus (HPV)",
                    "Chlamydia",
                    "Gonorrhea",
                    "Syphilis"
                }
        };
        var c2 = new Card
        {
            ID = 2,
            Category = "Law and Sex",
            Question = "What is sexual assualt?",
            Answer = "Any type of sexual contact without consent",
            Choices = new List<string>()
                {
                    "Touching someone on their genitals",
                    "Forcfully grabbing someone by their genitals",
                    "Any type of sexual contact without consent",
                    "hitting someone"
                }
        };

        var c3 = new Card
        {
            ID = 3,
            Category = "Studies and statistics",
            Question = "What’s the Average Person’s Number of Sexual Partners?",
            Answer = "7",
            Choices = new List<string>()
                {
                    "2",
                    "15",
                    "44",
                    "7"
                }
        };
        var c4 = new Card
        {
            ID = 4,
            Category = "Studies and statistics",
            Question = "What percentage of women always reach a climax during sex?",
            Answer = "29%",
            Choices = new List<string>()
                {
                    "40%",
                    "10%",
                    "65%",
                    "29%"
                }
        };
        var c5 = new Card
        {
            ID = 5,
            Category = "Sexual Health",
            Question = "Sexually transmitted bacterial infections (STIs) can be treated with what?",
            Answer = " Antibiotics ",
            Choices = new List<string>()
                {
                    "Antibiotics",
                    "Steroids",
                    "Antacids",
                    "antipsychotics"
                }
        };
        #endregion


        // Not currently being used, need to utilize this for random numbers?
        List<int> gamequestionNumbers = new List<int> { 1, 2, 3, 4 };

        Console.WriteLine("Welcome to Triviabate");

        var _canPlay = GetAgeInputWithMinorCheck();
        if (!_canPlay) return;

        Console.WriteLine("You're 18 or older let's get the party started!");

        Console.WriteLine("Choose a username! What would you like your username to be?");
        var _pUsername = Console.ReadLine();

        var aGame = new Game() { Player1 = _pUsername };
    }

    /// <summary>
    /// Get age input from the user and checks if the player is minor
    /// </summary>
    /// <returns>
    /// Boolean value True if the person is Adult, false if the player is a minor o input value wasn't an Integer
    /// </returns>>
    public static bool GetAgeInputWithMinorCheck()
    {
        Console.WriteLine("How old are you?");
        //this way we can handle the parsing result
        if (int.TryParse(Console.ReadLine(), out var _insertedAge))
        {
            //player is an Adult
            if (IsAdult(_insertedAge)) return true;
            //player is a minor
            Console.WriteLine("You are not authorized to play this game.You must be 18 or older.");
            return false;
        }
        //input is not vaild
        Console.WriteLine("Invalid Input Exiting Program...");
        return false;
    }

    public static bool IsAdult(int age) => age >= 18;

    //this can be a struct if we're not going to have any methods
    public struct Card
    {
        public int ID { get; set; }
        public string Category { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
        public List<string> Choices { get; set; }
    }

    public class Game
    {
        //can be something like public List<String> Players = new List<String>();
        public String? Player1 { get; set; }

        public String? Player2 { get; set; }
    }
}




// var aGame = new Game()

//Console.WriteLine("Welcome to Triviabate");


// Console.Write("Player 1 name");
// aGame.player1 = Console.ReadLine() ?? "Player 1";
// Console.Write("Player 1 age: ");
// aGame.Player1.Age = int.Parse(Console.ReadLine() ?? "18");

//  if (aGame.Player =< 17)
// Console.WriteLine("You are not authorized to play this game.You must be 18 or older."); )
// else if player => 18
//  Console.WriteLine("You're 18 or older let's get the party started!");
//else(player null)
//Console.WriteLine("No response was recieved please start over.");




//Console.Write("Player 2");
// aGame.player1 = Console.ReadLine() ?? "Player 1";