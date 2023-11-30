using System;
using System.Collections.Generic;

namespace TheHangMan
{
    public class Ilustrator : IIlustrator
    {
        private static readonly IIlustrator ilustrator = new Ilustrator();

        void IIlustrator.PrintEmpyGallows()
        {
            Console.WriteLine("    +-------+");
            Console.WriteLine("    |       |");
            Console.WriteLine("    |       ");
            Console.WriteLine("    |      ");
            Console.WriteLine("    |      ");
            Console.WriteLine("    |      ");
            Console.WriteLine("    |      ");
            Console.WriteLine("    |      ");
            Console.WriteLine("    |      ");
            Console.WriteLine("----|---------------");
        }

        void IIlustrator.PrintScreenHeader()
        {
            Console.WriteLine("--------------- THE HANGMAN TALE ---------------");
            Console.WriteLine("--- Guess the word before the man is hangged ---");
            Console.WriteLine("");
        }

        void IIlustrator.PrintLettersTried(List<char> lettersTried)
        {
            Console.Write("\n\nLetters tried: ");
            foreach (char letter in lettersTried)
            {
                Console.Write(letter + " ");
            }
        }

        void IIlustrator.PrintWord(List<char> guessedLetters, string currentWord)
        {
            Console.Write("\r\n");

            if (guessedLetters.Count == 0)
            {
                for (int i = 0; i <= currentWord.Length; i++)
                {
                    Console.Write("_ ");
                }
            } 
            else
            {
                foreach (char c in currentWord)
                {
                    if (guessedLetters.Contains(c))
                    {
                        Console.Write(c + " ");
                    }
                    else
                    {
                        Console.Write("_ ");
                    }
                }
            }
        }

        void IIlustrator.PrintHangMan(int amountOfBodyPartsToDisplay)
        {
            switch (amountOfBodyPartsToDisplay)
            {
                case 0:
                    ilustrator.PrintEmpyGallows();
                    break;
                case 1:
                    Console.WriteLine("    +-------+");
                    Console.WriteLine("    |       |");
                    Console.WriteLine("    |       O");
                    Console.WriteLine("    |      ");
                    Console.WriteLine("    |      ");
                    Console.WriteLine("    |      ");
                    Console.WriteLine("    |      ");
                    Console.WriteLine("    |      ");
                    Console.WriteLine("    |      ");
                    Console.WriteLine("----|---------------");
                    break; 
                case 2:
                    Console.WriteLine("    +-------+");
                    Console.WriteLine("    |       |");
                    Console.WriteLine("    |       O");
                    Console.WriteLine("    |       |");
                    Console.WriteLine("    |      ");
                    Console.WriteLine("    |      ");
                    Console.WriteLine("    |      ");
                    Console.WriteLine("    |      ");
                    Console.WriteLine("    |      ");
                    Console.WriteLine("----|---------------");
                    break;
                case 3:
                    Console.WriteLine("    +-------+");
                    Console.WriteLine("    |       |");
                    Console.WriteLine("    |       O");
                    Console.WriteLine("    |      /|\\");
                    Console.WriteLine("    |      ");
                    Console.WriteLine("    |      ");
                    Console.WriteLine("    |      ");
                    Console.WriteLine("    |      ");
                    Console.WriteLine("    |      ");
                    Console.WriteLine("----|---------------");
                    break;
                case 4:
                    Console.WriteLine("    +-------+");
                    Console.WriteLine("    |       |");
                    Console.WriteLine("    |       O");
                    Console.WriteLine("    |      /|\\");
                    Console.WriteLine("    |       |");
                    Console.WriteLine("    |      ");
                    Console.WriteLine("    |      ");
                    Console.WriteLine("    |      ");
                    Console.WriteLine("    |      ");
                    Console.WriteLine("----|---------------");
                    break;
                case 5:
                    Console.WriteLine("    +-------+");
                    Console.WriteLine("    |       |");
                    Console.WriteLine("    |       O");
                    Console.WriteLine("    |      /|\\");
                    Console.WriteLine("    |       |");
                    Console.WriteLine("    |       |");
                    Console.WriteLine("    |      ");
                    Console.WriteLine("    |      ");
                    Console.WriteLine("    |      ");
                    Console.WriteLine("----|---------------");
                    break;
                case 6:
                    Console.WriteLine("    +-------+");
                    Console.WriteLine("    |       |");
                    Console.WriteLine("    |       O");
                    Console.WriteLine("    |      /|\\");
                    Console.WriteLine("    |       |");
                    Console.WriteLine("    |       |");
                    Console.WriteLine("    |      / \\");
                    Console.WriteLine("    |      ");
                    Console.WriteLine("    |      ");
                    Console.WriteLine("----|---------------");
                    break;
                default:
                    ilustrator.PrintEmpyGallows();
                    break;
            }
        }
    }
}
