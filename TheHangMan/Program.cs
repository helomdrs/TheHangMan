using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace TheHangMan
{
    internal class Program
    {
        WordProvider wordProvider = WordProvider.GetInstance();

<<<<<<< Updated upstream
        private int MAX_MISTAKES_AVAILABLE = 5;
        private string currentWord = "";
=======
        public static int MAX_MISTAKES_AVAILABLE = 6;
        public static string currentWord = "";
>>>>>>> Stashed changes

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
<<<<<<< Updated upstream
            //printar aqui a forca vazia
            //escolher uma palavra e desenhar os traços
            //chamar gameloop
=======
            illustrator.PrintEmpyGallows();
            currentWord = wordProvider.GetNewWord();

            Console.Write("Word to Guess: ");

            for(int i = 0; i <= currentWord.Length; i++)
            {
                Console.Write("_ ");
            }

>>>>>>> Stashed changes
            MatchLoop();
            return;
        }

        private static void MatchLoop()
        {
            int currentMistakesMade = 0;
<<<<<<< Updated upstream
            List<char> wordsTried = new List<char>();
            //enquanto a palavra estiver sendo descoberta mantém o loop
=======
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
>>>>>>> Stashed changes

                Console.Write("\nGuess a letter: ");
                char guess = Console.ReadLine()[0];

                if (!lettersTried.Contains(guess)) 
                {
                    lettersTried.Add(guess);
                    bool guessedRight = TreatPlayerGuess(guess);
                 
                    if (guessedRight) 
                    { 
                        lettersGuessedAmount++; 
                    }
                    else
                    {
                        currentMistakesMade++;
                    }

                    illustrator.PrintHangMan(currentMistakesMade);
                    PrintWord(lettersTried);
                }
            }

            if (lettersGuessedAmount == currentWord.Length)
            {
                wonMatch = true;
            }

            MatchOver(wonMatch);
            return;
        }

        private static void PrintWord(List<char> guessedLetters) 
        {
            Console.Write("\r\n");

            foreach (char c in currentWord)
            {
                if(guessedLetters.Contains(c))
                {
                    Console.Write(c);
                }
                else 
                {
                    Console.Write("_ ");
                }
            }

            return;
        }

        private static bool TreatPlayerGuess(char c)
        {
            for (int i = 0; i < currentWord.Length; i++)
            {
                if (c == currentWord[i])
                {
                    return true;
                }
            }

            return false;
        }

        private static void MatchOver(bool wonMatch)
        {
            Console.Write("\r\n");
            Console.WriteLine(currentWord);

            string winMessage = "You win!";
            string looseMessage = "You loose...";
            
            if (wonMatch)
            {
                Console.WriteLine(winMessage);
            }
            else
            {
                Console.WriteLine(looseMessage);
            }

            Console.WriteLine("GAME OVER");
            Console.ReadLine();
            //ClearMatchScreen();
        }

        private static void ClearMatchScreen()
        {
            Console.Clear();
            WriteScreenHeader();
        }
    }
}
