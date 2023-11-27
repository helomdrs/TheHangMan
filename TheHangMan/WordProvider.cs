using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Xml.Linq;

namespace TheHangMan
{
    public sealed class WordProvider
    {
        private static WordProvider instance;

        private const string WORDS_FILE_NAME = "WordsBank.txt";

        private List<string> wordsUsed = new List<string>();
        private List<string> wordsBank;

        private Random random = new Random();

        public static WordProvider GetInstance() 
        { 
            if (instance == null)
            {
                instance = new WordProvider();
            }

            return instance; 
        }

        private WordProvider() 
        {
            GenerateWordsList();
        }

        private void GenerateWordsList()
        {
            //string filePath = "D:\\Documents\\Projects\\Unity\\TheHangMan\\TheHangMan\\WordsBank.txt";

            string filePath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"WordsBank.txt");
            wordsBank = new List<string>(File.ReadAllLines(filePath));
        }

        public string GetNewWord()
        {
            string wordToReturn = GetRandomWord();

            if (wordsUsed.Count == wordsBank.Count)
            {
                wordsUsed.Clear();
            }

            while (wordsUsed.Contains(wordToReturn))
            {
                wordToReturn = GetRandomWord();
            }

            wordsUsed.Add(wordToReturn);
            return wordToReturn.ToLower();
        }

        private string GetRandomWord()
        {
            return wordsBank[random.Next(0, wordsBank.Count)];
        }
    }
}
