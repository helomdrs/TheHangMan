using System;
using System.Collections.Generic;

namespace TheHangMan
{
    internal class Program
    {
        public static WordProvider wordProvider = WordProvider.GetInstance();
        public static IIlustrator ilustrator = new Ilustrator();

        public static int MAX_MISTAKES_AVAILABLE = 6;
        public static string currentWord = "";
        public static List<char> lettersTried = new List<char>();

        static void Main(string[] args)
        {
            ilustrator.WriteScreenHeader();
            StartMatch();
        }

        private static void StartMatch()
        {
            currentWord = wordProvider.GetNewWord();

            ilustrator.PrintEmpyGallows();
            ilustrator.PrintWord(lettersTried, currentWord);

            MatchLoop();
            return;
        }

        private static void MatchLoop()
        {
            int currentMistakesMade = 0;
            int lettersGuessedAmount = 0;
            bool wonMatch = false;
            
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

                        UpdateScreen(currentMistakesMade);
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

        private static void UpdateScreen(int mistakesMade)
        {
            Console.Clear();

            ilustrator.WriteScreenHeader();
            ilustrator.PrintHangMan(mistakesMade);
            ilustrator.PrintWord(lettersTried, currentWord);
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
            Console.Clear ();
            ilustrator.WriteScreenHeader();

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

            Console.WriteLine();
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
            lettersTried.Clear();
            currentWord = "";

            ilustrator.WriteScreenHeader();
            StartMatch();
        }
    }
}
