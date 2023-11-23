using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheHangMan
{
    internal class Program
    {
        static void Main(string[] args)
        {
           WordProvider wordProvider = WordProvider.GetInstance();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(wordProvider.GetNewWord() + "\n");
            }

            Console.ReadLine();
        }
    }
}
