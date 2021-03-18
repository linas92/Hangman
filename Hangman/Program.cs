using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    class Program
    {
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
            Hangman();
            Console.WriteLine();
            Console.WriteLine("Press any key to close the console");
            Console.ReadKey();
        }
        public static void Hangman()
        {
            List<char> correctGuesses = new List<char>();
            List<char> incorrectGuesses = new List<char>();

        }
    }
}