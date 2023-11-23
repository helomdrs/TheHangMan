using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheHangMan
{
    internal class Program
    {
        WordProvider wordProvider = WordProvider.GetInstance();

        private int MAX_MISTAKES_AVAILABLE = 5;
        private string currentWord = "";

        static void Main(string[] args)
        {
            WriteScreenHeader();
            StartMatch();

            Console.ReadLine();
        }

        static void WriteScreenHeader()
        {
            Console.WriteLine("--------------- The Hangman Tale ---------------\n");
            Console.WriteLine("--- Guess the word before the man is hangged ---\n");
        }

        static void StartMatch()
        {
            //printar aqui a forca vazia
            //escolher uma palavra e desenhar os traços
            //chamar gameloop
            MatchLoop();
        }

        static void MatchLoop()
        {
            int currentMistakesMade = 0;
            List<char> wordsTried = new List<char>();
            //enquanto a palavra estiver sendo descoberta mantém o loop

            ClearMatchScreen();
        }

        static void ClearMatchScreen()
        {
            Console.Clear();
            WriteScreenHeader();
        }
    }
}
