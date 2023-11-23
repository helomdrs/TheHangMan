using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheHangMan
{
    public class Program
    {
        public static WordProvider wordProvider = WordProvider.GetInstance();
        public static Illustrator illustrator = new Illustrator();

        //private int MAX_MISTAKES_AVAILABLE = 6;
        public static string currentWord = "";

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
            illustrator.PrintEmpyGallows();
            currentWord = wordProvider.GetNewWord();


            Console.WriteLine("\nNew word is " + currentWord);

            //escolher uma palavra e desenhar os traços
            //chamar gameloop
            MatchLoop();
        }

        static void MatchLoop()
        {
            //int currentMistakesMade = 0;
            //List<char> wordsTried = new List<char>();
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
