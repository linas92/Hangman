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

            Console.WriteLine("\n\n\n\n\nUPDATE 101! THEMES ARE TOO MAINSTREAM AND YOU'RE ALREADY DEAD"); //"to hell with this, atleast its working" - mode engaged
        }
        public static void ThePrettyHangmansNoose()
        {
            Console.WriteLine(" ------|");
            Console.WriteLine($"|      o\n|     \\|/     \n|      0\n|     / \\\n|     \n|     \n|");
            Console.WriteLine("-----");
        } // Looks good, does nothing
        public static void Theme()
        {
            /*string []LithuanianNames = { "Tomas", "Darius", "Alfonsas", "Karolis", "Edgaras",
            "Margarita", "Simona", "Onute", "Olga", "Pamela"};

            //string []LithuanianCities = { "Kaunas", "Vilnius", "Marijampole",
                    "Vilkaviskis", "Alytus", "Jieznas", "Lazdijai", "Pakruojis", "Sakiai"};

            //string []WorldCountryNames = { "Australija", "Bulgarija", "Danija", "Filipinai",
            "Japonija", "Kanada", "Maldyvai", "Norvegija", "Prancūzija", "Senegalas"};

           //string []Animals = { "Elephant", "Lion", "Tiger", "Koala", "Shark",
                    "Whale", "Octopus", "Snake", "Kangaroo", "Bear", "Lizard", "Squirrel","Cow",
                    "Crocodile", "Pelican", "Dolphin", "Bat", "Frog", "Badger","Wolf","Cow", "Ox",
                    "Reindeer", "Fox", "Bat", "Sparrow", "Chimpanzee"};*/
        }
        static void Main(string[] args)
        {
            Rules();
            ThePrettyHangmansNoose();
            Theme();

            Random RandomWordSelecter = new Random((int)DateTime.Now.Ticks);

            string[] ToHellWithThis = {"Tomas", "Darius", "Alfonsas", "Karolis", "Edgaras", "Margarita", "Simona", "Onute", "Olga",
                "Pamela", "Kaunas", "Vilnius", "Marijampole",  "Vilkaviskis", "Alytus", "Jieznas", "Lazdijai", "Pakruojis", "Sakiai",
                "Australija", "Bulgarija", "Danija", "Filipinai", "Japonija", "Kanada", "Maldyvai", "Norvegija", "Prancūzija",
                "Senegalas",  "Elephant", "Lion", "Tiger", "Koala", "Shark", "Whale", "Octopus", "Snake", "Kangaroo", "Bear",
                "Lizard", "Squirrel","Cow","Crocodile", "Pelican", "Dolphin", "Bat", "Frog", "Badger","Wolf","Cow", "Ox","Reindeer",
                "Fox", "Bat", "Sparrow", "Chimpanzee"};

            string LetterGuess = ToHellWithThis[RandomWordSelecter.Next(0, ToHellWithThis.Length)];
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
            int LivesLeft = 6;
            /*
            string PlayerChoosingTheTheme = Console.ReadLine();
                        

            while (int.TryParse(PlayerChoosingTheTheme, out int Result) == false)
            {
                Console.WriteLine("Wrong symbol, we only accept NUMBERS from 1 to 4");
                PlayerChoosingTheTheme = Console.ReadLine();
            }
            if (PlayerChoosingTheTheme == "1" || PlayerChoosingTheTheme == "2" || PlayerChoosingTheTheme == "3")
            {
                Console.WriteLine("Congrats on choosing the boring theme");
            }
            else if (PlayerChoosingTheTheme == "4")
            {
                Console.WriteLine("You chose Animals. Congratulations my dear friend! You finally chose the fun one!");
            }
            }
            */
            while (!Wienner && LivesLeft > 0)
            {
                Console.WriteLine("Time to guess a letter: ");

                PlayersInput = Console.ReadLine().ToUpper();
                Guess = PlayersInput[0];

                if (GoodGuess.Contains(Guess))
                {
                    Console.WriteLine($"You cannot try to guess this letter again as it was already guessed right {Guess}");
                    continue;
                }

                else if (BadGuess.Contains(Guess))
                {
                    Console.WriteLine($"You've tried this and it didn't work. Try a different lettern than: { Guess}");
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
                    Console.WriteLine($"Bad guess. Try again");
                    LivesLeft--;
                }

                Console.WriteLine(LettersThatChangeWhenPlayerGuesses.ToString());
            }

                if (Wienner)
                    Console.WriteLine("YOU WON! Email me all your personal info at yo_mamma@gmail.com to claim your prize");
                else
                    Console.WriteLine($"You lost. You're too cool so go back to school. \nThe word was: {LetterGuess}");

                Console.WriteLine("\n\n\n\n\nPress any key to close the console");
                Console.ReadKey();
         }
    }
}