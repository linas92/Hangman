using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    class Program
    {
        public static void ChoosingTheTheme()
        {
            string[] Animals = { "Elephant", "Lion", "Tiger", "Koala", "Shark",
            "Whale", "Octopus", "Snake", "Kangaroo", "Bear", "Lizard", "Squirrel","Cow",
            "Crocodile", "Pelican", "Dolphin", "Bat", "Frog", "Badger","Wolf","Cow", "Ox",
            "Reindeer", "Fox", "Bat", "Sparrow", "Chimpanzee"};
            string[] LithuanianCities = { "Kaunas", "Vilnius", "Marijampole",
            "Vilkaviskis", "Alytus", "Jieznas", "Lazdijai", "Pakruojis", "Sakiai", };
            string[] Vardai = { "Tomas", "Darius", "Alfonsas", "Karolis", "Edgaras",
            "Margarita", "Simona", "Onute", "Inga", "Pamela"};
            string[] Valstybes = { "Australija", "Bulgarija", "Danija", "Filipinai",
            "Japonija", "Kanada", "Maldyvai", "Norvegija", "Prancūzija", "Senegalas"};
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello and welcome to the game called Hangman");
            Console.WriteLine("We will be hanging you, unless you guess the word");
            Console.WriteLine("There are 4 themes you can choose from");
            Console.WriteLine("1. Lithuanian names");
            Console.WriteLine("2. Lithuanian cities");
            Console.WriteLine("3. World country names");
            Console.WriteLine("4. Animals");
            Console.WriteLine("Press 1,2,3 or 4 to choose the theme that you would like to play");
            char ChooseTheTheme = Console.ReadKey().KeyChar;
            int Skaicius = 0;

            if (int.TryParse(ChooseTheTheme.ToString(), out Skaicius))
            //LOOKS GOOD DOESNT WORK
            {
                if (Skaicius<1&&Skaicius>4)
                {
                    Console.WriteLine("You chose wrong. Do it again");
                }
            }
            if (ChooseTheTheme==1|| ChooseTheTheme==2|| ChooseTheTheme==3|| ChooseTheTheme==4)
            {
                Hangman();
            }
            else
            {
                Console.WriteLine("\nPress 1,2,3 or 4 to choose the theme that you would like to play");
            }
            Console.WriteLine();
            Console.WriteLine("Press any key to close the console");
            Console.ReadKey();
        }
        public static void Hangman()
        {
            Random RandomWordSelecter = new Random((int)DateTime.Now.Ticks);

            int LivesLeft = 5;
            bool Wienner = false;
            string PlayersInput;
            int LettersThePlayerAlreadyGuessed = 0;
            char Guess;

            string LetterGuess = Animals[RandomWordSelecter.Next(0, Animals.Length)];

            List<char> GoodGuess = new List<char>();
            List<char> BadGuess = new List<char>();

            StringBuilder LettersThatChangeWhenPlayerGuesses = new StringBuilder(LetterGuess.Length);

            for (int i = 0; i < LetterGuess.Length; i++)
                LettersThatChangeWhenPlayerGuesses.Append('_');
            while (LivesLeft != 0 && Wienner != true)
            {
                Console.WriteLine("Human! Time to guess a letter");
                PlayersInput = Console.ReadLine();
                Guess = PlayersInput[0];
                if (GoodGuess.Contains(Guess))
                {
                    Console.WriteLine("You cannot try to guess this letter again as it was already guessed right ");
                    continue;
                }
                else if (BadGuess.Contains(Guess))
                {
                    Console.WriteLine("You've tried this and it didn't work!");
                    Console.WriteLine("You can do better than this guesss: ", Guess);
                    continue;
                }
                if (LetterGuess.Contains(Guess))
                {
                    GoodGuess.Add(Guess);
                    for (int i = 0; i < LetterGuess.Length; i++)
                    {
                        if (LetterGuess[i] == Guess)
                        {
                            LettersThatChangeWhenPlayerGuesses[i] = LetterGuess[i];
                            LettersThePlayerAlreadyGuessed++;
                        }
                    }
                    if (LettersThePlayerAlreadyGuessed == LetterGuess.Length)
                        Wienner = true;
                }
                else
                {
                    BadGuess.Add(Guess);
                    Console.WriteLine($"Bad guess mother N*gger! There was no {Guess} in word!");
                    Console.WriteLine("RACIST BASTARD! THE WORD WAS NAGGER!\nNOW YOU DESERVE A HANGING!!!");
                    LivesLeft--;
                }
                Console.WriteLine(LettersThatChangeWhenPlayerGuesses.ToString());
            }
            if (Wienner)
            {
                Console.WriteLine("YOU WON!");
                Console.WriteLine($"Email me \"yo_mama@gmail.com\" your bank account number, ID card photo," +
                    $"your first pets name, first school and you will get 1,000,000$ dollars!");
            }
            else
            {
                Console.WriteLine("You lost you! Back to school");
            }
        }
    }
}
/*
            Console.WriteLine(" --------|");
            Console.WriteLine("|\n|\n|\n|\n|\n|\n|");
            Console.WriteLine("-----");

TRY PARSE 
KARTOTI CIKLE IVESTI 
FIX THIS SHIT 21-29 EULUTES

            //LOOKS GOOD DOESNT WORK
            //Fix the Animals + LithuanianCities + Vardai + Valstybes

*/