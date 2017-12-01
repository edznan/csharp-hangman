using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hangman
{

    class Program
    {
        static void Main(string[] args)
        {
            bool a = true;
            Console.WriteLine("Welcome!");
            string[] words = new string[25];
            words[0] = "bottle";
            words[1] = "game";
            words[2] = "crash";
            words[3] = "pineapple";
            words[4] = "screen";
            words[5] = "smartphone";
            words[6] = "flower";
            words[7] = "blackberry";
            words[8] = "fire";
            words[9] = "water";
            words[10] = "truck";
            words[11] = "paper";
            words[12] = "color";
            words[13] = "machine";
            words[14] = "book";
            words[15] = "coffee";
            words[16] = "tea";
            words[17] = "supermarket";
            words[18] = "highway";
            words[19] = "road";
            words[20] = "door";
            words[21] = "building";
            words[22] = "spaceship";
            words[23] = "programming";
            words[24] = "tower";

            Random rnd = new Random();
            var mix = rnd.Next(0, 25);
            string chosenWord = words[mix];
            char[] guess = new char[chosenWord.Length];
            Console.WriteLine("Please enter your guess: ");

            for (int p = 0; p < chosenWord.Length; p++)
                guess[p] = '*';

            while (a)
            {
                char playerGuess = char.Parse(Console.ReadLine());
                for (int j = 0; j < chosenWord.Length; j++)
                {
                    if (playerGuess == chosenWord[j])
                        guess[j] = playerGuess;
                }
                Console.WriteLine(guess);
                if (new string(guess) == chosenWord)
                    a = false;
            }
            Console.WriteLine("Write the entire word.");
            Console.ReadLine();
        }
    }
}