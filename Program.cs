using System;
using System.Collections.Generic;

//namespace Final; //needed ; not {}

public class Card
{

    public int ID { get; set; }
    public string? Category { get; set; }
    public string? Question { get; set; }
    public string? Answer { get; set; }
    public List<string>? Choices { get; set; }

}

public class Deck

{
    public Deck()
    {
        //  - underscore usually means private 
        _cards = new List<Card>();

    }

    private List<Card> _cards { get; set; }
    public Card DrawCard()
    {
        var card = PickRandomCard();
        RemoveCard(card);
        return card;
    }

    private Card PickRandomCard()
    {
        

        int randomMax = _cards.Count;

        Random r = new Random();
        int randomCardIndex = r.Next(0, randomMax);

        return _cards[randomCardIndex];

    }


    
    public void AddCard(Card card)
    {
        _cards.Add(card);
    }

    
    public void RemoveCard(Card card)
    {
        _cards.Remove(card);
    }

    
    public bool IsEmpty()
    {
        return _cards.Count == 0;
    }


}

public class Program
{
    public static void Main(string[] args)
    {

        


      

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


        
        deck.AddCard(c1);
        deck.AddCard(c2);
        deck.AddCard(c3);
        deck.AddCard(c4);
        deck.AddCard(c5);


        Console.WriteLine("Welcome to Triviabate");

        var _canPlay = GetAgeInputWithMinorCheck();
        if (!_canPlay) return;

        Console.WriteLine("You're 18 or older let's get the party started!");



        
        int score = 0;
        while (!deck.IsEmpty())
        {
            // Since deck isnt empty, there will be at least one card left to draw..
            Card theDrawnCard = deck.DrawCard();
            if (theDrawnCard == null)
            {
                Console.WriteLine("Error: Even though the deck was not empty, a card could not be drawn!");
                return;
            }

            if (theDrawnCard.Choices == null)
            {
                Console.WriteLine("Error: No choices were on the card!");
                return;
            }

            Console.WriteLine(theDrawnCard.Question);

            Console.WriteLine("Choices:");
            int numChoices = theDrawnCard.Choices.Count;
            for (int i = 0; i < numChoices; i++)
            {
                int choiceNum = i + 1;
                string choiceText = theDrawnCard.Choices[i];
                Console.WriteLine(choiceNum + ": " + choiceText);
            }

            int ans; // 1-4 //while loop
            bool convertedToIntSuccessfully = int.TryParse(Console.ReadLine(), out ans);
            while (!convertedToIntSuccessfully || !(ans >= 1 && ans <= theDrawnCard.Choices.Count))
            {
                Console.WriteLine("That is not a valid choice!");
                convertedToIntSuccessfully = int.TryParse(Console.ReadLine(), out ans);
            }

            if (theDrawnCard.Choices[ans - 1] == theDrawnCard.Answer) 
            {
                Console.WriteLine("Good job!");
                score++;
            }
            else
            {
                Console.WriteLine("Wrong Answer");
            }
        }

        Console.WriteLine("You completed all the cards in the deck. Your score is " + score + ".");
    }

    public static bool GetAgeInputWithMinorCheck()
    {
        Console.WriteLine("How old are you?");
        //for parsing result
        if (int.TryParse(Console.ReadLine(), out var _insertedAge))
        {
            //player is an Adult
            if (IsAdult(_insertedAge)) return true;
            //player is a minor
            Console.WriteLine("You are not authorized to play this game.You must be 18 or older.");
            return false;
        }
        // not vaild
        Console.WriteLine("Invalid Input Exiting Program...");
        return false;
    }

    //bool 

    public static bool IsAdult(int age)
    {
        return age >= 18;
    }

}




// var aGame = new Game()

//Console.WriteLine("Welcome to Triviabate");


// Console.Write("Player 1 name");
// aGame.player1 = Console.ReadLine() ?? "Player 1";
// Console.Write("Player 1 age: ");
// aGame.Player1.Age = int.Parse(Console.ReadLine() ?? "18");

//  if (aGame.Player =< 17)
// Console.WriteLine("You are not authorized to play this game.You must be 18 or older."); 
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

//Console.Readline()



//Console.WriteLine("Choose a username! What would you like your username to be?");


