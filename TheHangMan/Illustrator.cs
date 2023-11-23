using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheHangMan
{
    public class Illustrator
    {
        public void PrintEmpyGallows()
        {
            Console.WriteLine("\n    +-------+");
            Console.WriteLine("\n    |       |");
            Console.WriteLine("\n    |       ");
            Console.WriteLine("\n    |      ");
            Console.WriteLine("\n    |      ");
            Console.WriteLine("\n    |      ");
            Console.WriteLine("\n    |      ");
            Console.WriteLine("\n    |      ");
            Console.WriteLine("\n    |      ");
            Console.WriteLine("\n----|---------------");
        }

        public void PrintHangMan(int amountOfBodyPartsToDisplay)
        {
            switch (amountOfBodyPartsToDisplay)
            {
                case 0:
                    PrintEmpyGallows();
                    break;
                case 1:
                    Console.WriteLine("\n    +-------+");
                    Console.WriteLine("\n    |       |");
                    Console.WriteLine("\n    |       O");
                    Console.WriteLine("\n    |      ");
                    Console.WriteLine("\n    |      ");
                    Console.WriteLine("\n    |      ");
                    Console.WriteLine("\n    |      ");
                    Console.WriteLine("\n    |      ");
                    Console.WriteLine("\n    |      ");
                    Console.WriteLine("\n----|---------------");
                    break; 
                case 2:
                    Console.WriteLine("\n    +-------+");
                    Console.WriteLine("\n    |       |");
                    Console.WriteLine("\n    |       O");
                    Console.WriteLine("\n    |       |");
                    Console.WriteLine("\n    |      ");
                    Console.WriteLine("\n    |      ");
                    Console.WriteLine("\n    |      ");
                    Console.WriteLine("\n    |      ");
                    Console.WriteLine("\n    |      ");
                    Console.WriteLine("\n----|---------------");
                    break;
                case 3:
                    Console.WriteLine("\n    +-------+");
                    Console.WriteLine("\n    |       |");
                    Console.WriteLine("\n    |       O");
                    Console.WriteLine("\n    |      /|\\");
                    Console.WriteLine("\n    |      ");
                    Console.WriteLine("\n    |      ");
                    Console.WriteLine("\n    |      ");
                    Console.WriteLine("\n    |      ");
                    Console.WriteLine("\n    |      ");
                    Console.WriteLine("\n----|---------------");
                    break;
                case 4:
                    Console.WriteLine("\n    +-------+");
                    Console.WriteLine("\n    |       |");
                    Console.WriteLine("\n    |       O");
                    Console.WriteLine("\n    |      /|\\");
                    Console.WriteLine("\n    |       |");
                    Console.WriteLine("\n    |      ");
                    Console.WriteLine("\n    |      ");
                    Console.WriteLine("\n    |      ");
                    Console.WriteLine("\n    |      ");
                    Console.WriteLine("\n----|---------------");
                    break;
                case 5:
                    Console.WriteLine("\n    +-------+");
                    Console.WriteLine("\n    |       |");
                    Console.WriteLine("\n    |       O");
                    Console.WriteLine("\n    |      /|\\");
                    Console.WriteLine("\n    |       |");
                    Console.WriteLine("\n    |       |");
                    Console.WriteLine("\n    |      ");
                    Console.WriteLine("\n    |      ");
                    Console.WriteLine("\n    |      ");
                    Console.WriteLine("\n----|---------------");
                    break;
                case 6:
                    Console.WriteLine("\n    +-------+");
                    Console.WriteLine("\n    |       |");
                    Console.WriteLine("\n    |       O");
                    Console.WriteLine("\n    |      /|\\");
                    Console.WriteLine("\n    |       |");
                    Console.WriteLine("\n    |       |");
                    Console.WriteLine("\n    |      / \\");
                    Console.WriteLine("\n    |      ");
                    Console.WriteLine("\n    |      ");
                    Console.WriteLine("\n----|---------------");
                    break;
                default:
                    PrintEmpyGallows();
                    break;
            }
        }
    }
}
