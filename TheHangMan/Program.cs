using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;

namespace TheHangMan
{
    internal class Program
    {
        public static WordProvider wordProvider = WordProvider.GetInstance();

        public static int MAX_MISTAKES_AVAILABLE = 6;
        public static string currentWord = "";

        static void Main(string[] args)
        {
            WriteScreenHeader();
            StartMatch();
        }

        private static void WriteScreenHeader()
        {
            Console.WriteLine("--------------- THE HANGMAN TALE ---------------");
            Console.WriteLine("--- Guess the word before the man is hangged ---");
        }

        private static void StartMatch()
        {
            Illustrator.PrintEmpyGallows();
            currentWord = wordProvider.GetNewWord();

            for(int i = 0; i <= currentWord.Length; i++)
            {
                Console.Write("_ ");
            }

            MatchLoop();
            return;
        }

        private static void MatchLoop()
        {
            int currentMistakesMade = 0;
            int lettersGuessedAmount = 0;
            bool wonMatch = false;
            List<char> lettersTried = new List<char>();
            
            while (currentMistakesMade != MAX_MISTAKES_AVAILABLE && lettersGuessedAmount != currentWord.Length) 
            {
                Console.Write("\n\nLetters tried: ");
                foreach (char letter in lettersTried)
                {
                    Console.Write(letter + " ");
                }

                Console.Write("\nGuess a letter: ");
                string input = Console.ReadLine();

                if (input.Length != 0)
                {
                    char guess = input[0];
                    if (!lettersTried.Contains(guess))
                    {
                        lettersTried.Add(guess);
                        int lettersGuessed = TreatPlayerGuess(guess);

                        if (lettersGuessed > 0)
                        {
                            lettersGuessedAmount += lettersGuessed;
                        }
                        else
                        {
                            currentMistakesMade++;
                        }

                        UpdateScreen(currentMistakesMade, lettersTried);
                    } 
                }
            }

            if (lettersGuessedAmount == currentWord.Length)
            {
                wonMatch = true;
            }

            MatchOver(wonMatch);
            return;
        }

        private static void UpdateScreen(int mistakesMade, List<char> lettersTried)
        {
            Console.Clear();

            WriteScreenHeader();
            Illustrator.PrintHangMan(mistakesMade);
            PrintWord(lettersTried);
        }


        private static void PrintWord(List<char> guessedLetters) 
        {
            Console.Write("\r\n");

            foreach (char c in currentWord)
            {
                if(guessedLetters.Contains(c))
                {
                    Console.Write(c + " ");
                }
                else 
                {
                    Console.Write("_ ");
                }
            }

            return;
        }

        private static int TreatPlayerGuess(char c)
        {
            int amountOfLettersDiscovered = 0;

            for (int i = 0; i < currentWord.Length; i++)
            {
                if (c == currentWord[i])
                {
                    amountOfLettersDiscovered++;
                }
            }

            return amountOfLettersDiscovered;
        }

        private static void MatchOver(bool wonMatch)
        {
            Console.Write("\r\n");

            string wordInfo = " The word was " + currentWord + ".";
            string winMessage = "You win!";
            string looseMessage = "You loose...";
            
            if (wonMatch)
            {
                Console.WriteLine(winMessage + wordInfo);
            }
            else
            {
                Console.WriteLine(looseMessage + wordInfo);
            }

            RequestRestart();
        }

        private static void RequestRestart() 
        {
            Console.Write("Do you wanna play again? y/n ");
            char userResponse = Console.ReadLine()[0];

            switch (userResponse)
            {
                case 'y':
                    Console.WriteLine("Press to start a new match.");
                    Console.ReadLine();
                    RestartMatch();
                    break;
                case 'n':
                    Console.WriteLine("Press to close the application.");
                    Console.ReadLine();
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Please choose only y/n for the answer!");
                    RequestRestart();
                    break;
            }
        }

        private static void RestartMatch()
        {
            Console.Clear();
            WriteScreenHeader();
            StartMatch();
        }
    }
}
