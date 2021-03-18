using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    class Program
    {
        public static string()
            {

            }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello and welcome to the game called Hangman");
            Console.WriteLine("We will be hanging you, unless you guess the word");
            Console.WriteLine("There are 4 themes you can choose from");
            Console.WriteLine("1. Lithuanian names");
            Console.WriteLine("2. Lithuanian cities");
            Console.WriteLine("3. World countries");
            Console.WriteLine("4. Animals");
            Console.WriteLine("Press 1,2,3 or 4 to choose the theme that you would like to play");
            int ChooseTheTheme = int.Parse(Console.ReadLine());
            Hangman();
            
            Console.WriteLine();
            Console.WriteLine("Press any key to close the console");
            Console.ReadKey();

            Console.WriteLine(" --------|");
            Console.WriteLine("|\n|\n|\n|\n|\n|\n|");
            Console.WriteLine("-----");
        }
        public static void Hangman()
        {
            Random RandomWordSelecter = new Random((int)DateTime.Now.Ticks);

            string[] Animals = { "Elephant", "Lion", "Tiger", "Koala", "Shark", "Whale",
            "Octopus", "Snake", "Kangaroo", "Bear", "Lizard", "Squirrel","Cow",
            "Crocodile", "Pelican", "Dolphin", "Bat", "Frog", "Badger","Wolf","Cow",
            "Ox", "Reindeer", "Fox", "Bat", "Sparrow", "Chimpanzee"};
            string[]LithuanianCities = { "Kaunas", "Vilnius", "Marijampole", "Vilkaviskis",
                "Alytus", "Jieznas", "Lazdijai", "Pakruojis", "Sakiai", };

            int LivesLeft = 5;
            bool Wienner = false;
            int PlayersInput;
            char Guess;

            if ( == 1|| )
            {

            }

            while (LivesLeft != 0 && Wienner != true)
            {

            }
        }
    }
}

/*
VARDAI:
Tomas
Darius
Alfonsas
Karolis
Edgaras
Margarita
Simona
Onute
Inga
Pamela

LIETUVOS MIESTAI:











VALSTYBES:
Australija
Bulgarija
Danija
Filipinai
Japonija
Kanada
Maldyvai
Norvegija
Prancūzija
Senegalas
*/