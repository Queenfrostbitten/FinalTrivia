using System.Collections.Generic;

namespace Final;

   public class Card
{
   
        public int ID { get; set; }
    public string ?Category { get; set; }
    public string ?Question { get; set; }
    public string ?Answer { get; set; }
    public List<string> ?Choices { get; set; }
    
}
public class Deck

{
    public Deck()
    {
        Cards = new List<Card>();

    }

    public List<Card> Cards { get; set; }
    public Card Draw() 
        


        { var card = PickRandomCard();
            RemoveCard(card);
            return card;
        }

    private Card PickRandomCard()
    {
        Cards.Count()
            Random().Next(< int.5 >)
            }
                     }
  

        RandomCard(c1.Cards.Where);


    }
    public class Program
{
    public static void Main(string[] args)
    {

        while (Deck.Cards.Count > 0)
        { Console.ReadLine(Choices); }


        int[] deck = { c1, c2, c3 c4, c5 };
        var deck = new Deck();
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
            Question = "What is sexual assault?",
            Answer = "Any type of sexual contact without consent",
            Choices = new List<string>()
                {
                    "Touching someone on their genitals",
                    "Forcefully grabbing someone by their genitals",
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




        Console.WriteLine("Welcome to Triviabate");

        var _canPlay = GetAgeInputWithMinorCheck();
        if (!_canPlay) return;

        Console.WriteLine("You're 18 or older let's get the party started!");



    }

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
    
        var score = 0;
        foreach (var _card in cards)
        {
        }
        for (int i = 0; i< 5; i++)
        {
            if (cards[i].Question == cards[i + 1].Question)
            {
                
            }
            Console.WriteLine(cards[i].Question);
            var ans = Console.ReadLine();
            if (ans.ToLower() == cards[i].Answer || cards[i].Answer.Contains(ans))
            {
                
                Console.WriteLine("Good job!");
                continue;
            }
             Console.WriteLine("Wrong Answer");


//Main loop
    

      var Deck = new Deck();

  int Counter = 5;
  while (Deck.Cards.Count > 0)

{
    Console.WriteLine("Knowledge Test:{5}");

    Deck.Draw();

    Deck.Cards.Add(c1);
    Deck.Cards.Add(c2);
    Deck.Cards.Add(c3);
    Deck.Cards.Add(c4);
    Deck.Cards.Add(c5);

    Console.WriteLine("Do you wish to continue? Y or N")
        var char = Console.ReadLine();

    if(char == 'N')
    {
        wantstoContinue = false;
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











//str = Console.ReadLine();
//str = Console.WriteLine();
//public string player;
// static void Main(String[] args);
//var aGame = new Game(Console.Out);
//List<int> gamequestionNumbers = new List<int>(1, 2, 3, 4);






//Run(aGame, random);



//Console.WriteLine("How old are you?");
//Console.Readline()



//Console.WriteLine("Choose a username! What would you like your username to be?");


