using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    class Program
    {
        public static void Rules()
        {
            Console.WriteLine("Hello and welcome to the game called Sarcastic Hangman");
            Console.WriteLine("We will be hanging you! Unless of course you guess the correct word");
            Console.WriteLine("There are 4 themes you can choose from");
            Console.WriteLine("1. Lithuanian names");
            Console.WriteLine("2. Lithuanian cities");
            Console.WriteLine("3. World country names");
            Console.WriteLine("4. Animals");
            Console.WriteLine("Press 1,2,3 or 4 to choose the theme that you would like to play");
        }
        public static void ThePrettyHangmansNoose()
        {
            Console.WriteLine(" --------|");
            Console.WriteLine("|\n|\n|\n|\n|\n|\n|");
            Console.WriteLine("-----");
        } // LOOKS GREAT DOESN"T WORK
        public static void Theme()
        {
            string []LithuanianNames = { "Tomas", "Darius", "Alfonsas", "Karolis", "Edgaras",
            "Margarita", "Simona", "Onute", "Olga", "Pamela"};

            string []LithuanianCities = { "Kaunas", "Vilnius", "Marijampole",
                    "Vilkaviskis", "Alytus", "Jieznas", "Lazdijai", "Pakruojis", "Sakiai"};

            string []WorldCountryNames = { "Australija", "Bulgarija", "Danija", "Filipinai",
            "Japonija", "Kanada", "Maldyvai", "Norvegija", "Prancūzija", "Senegalas"};

            string []Animals = { "Elephant", "Lion", "Tiger", "Koala", "Shark",
                    "Whale", "Octopus", "Snake", "Kangaroo", "Bear", "Lizard", "Squirrel","Cow",
                    "Crocodile", "Pelican", "Dolphin", "Bat", "Frog", "Badger","Wolf","Cow", "Ox",
                    "Reindeer", "Fox", "Bat", "Sparrow", "Chimpanzee"};
        }
        static void Main(string[] args)
        {
            Rules();
            ThePrettyHangmansNoose();
            Theme();

            Random RandomWordSelecter = new Random((int)DateTime.Now.Ticks);

            string LetterGuess = Theme()[RandomWordSelecter.Next(0, Theme().Length)]; //DOESN"T WORK

            string WordsCapsLocked = LetterGuess.ToUpper();

            StringBuilder LettersThatChangeWhenPlayerGuesses = new StringBuilder(LetterGuess.Length);

            for (int i = 0; i < LetterGuess.Length; i++)
                LettersThatChangeWhenPlayerGuesses.Append('_');

            List<char> GoodGuess = new List<char>();
            List<char> BadGuess = new List<char>();

            bool Wienner = false;
            string PlayersInput;
            int LettersThePlayerAlreadyGuessed = 0;
            char Guess;
            int LivesLeft = 5;

            string PlayerChoosingTheTheme = Console.ReadLine();

            if (int.TryParse(PlayerChoosingTheTheme, out int Result) == false)
            {
                Console.WriteLine("Wrong symbol, we only accept NUMBERS from 1 to 4");
                PlayerChoosingTheTheme = Console.ReadLine();
            }

            else if (PlayerChoosingTheTheme == "1" || PlayerChoosingTheTheme == "2" || PlayerChoosingTheTheme == "3")
            {
                Console.WriteLine("Congrats on choosing the boring theme");
            }
            else if (PlayerChoosingTheTheme == "4")
            {
                Console.WriteLine("You chose Animals. Congratulations my dear friend! You finally chose the fun one!");
            }

            while (!Wienner && LivesLeft > 0)
            {
                Console.WriteLine("Human! Time to guess a letter");

                PlayersInput = Console.ReadLine().ToUpper();
                Guess = PlayersInput[0];

                if (GoodGuess.Contains(Guess))
                {
                    Console.WriteLine($"You cannot try to guess this letter again as it was already guessed right {Guess}");
                    ThePrettyHangmansNoose();
                    continue;
                }

                else if (BadGuess.Contains(Guess))
                {
                    Console.WriteLine("You've tried this and it didn't work!");
                    Console.WriteLine($"You can do better than this guesss {Guess}");
                    Console.WriteLine($"You have {LivesLeft} lives left");

                    ThePrettyHangmansNoose();
                    continue;
                }

                if (WordsCapsLocked.Contains(Guess))
                {
                    GoodGuess.Add(Guess);
                    for (int i = 0; i < LetterGuess.Length; i++)
                    {
                        if (WordsCapsLocked[i] == Guess)
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
                    Console.WriteLine($"Bad guess N*gger! There was no \"{Guess}\" in that word!");
                    Console.WriteLine("O\nM\nG\nDid you think I used the N word? Lol it was N A G G E R");
                    Console.Clear();
                    Console.WriteLine($"You have {LivesLeft--} lives left");
                    LivesLeft--;
                }
                Console.WriteLine(LettersThatChangeWhenPlayerGuesses.ToString());
                if (Wienner)
                {
                    Console.WriteLine("YOU WON!");
                    Console.WriteLine($"Email me \"yo_mamma@gmail.com\" your bank account number, ID card photo," +
                        $"your first pets name, first school and you will get 1,000,000$ dollars!");
                }
                else
                {
                    Console.WriteLine("You lost  You're too cool so go back to school");
                }
                Console.WriteLine();
                Console.WriteLine("Press any key to close the console");
                Console.ReadKey();
            }
        }
    }
}