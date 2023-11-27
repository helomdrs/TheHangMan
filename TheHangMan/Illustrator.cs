using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheHangMan
{
    public class Illustrator
    {
        public static void PrintEmpyGallows()
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

        public static void PrintHangMan(int amountOfBodyPartsToDisplay)
        {
            switch (amountOfBodyPartsToDisplay)
            {
                case 0:
                    PrintEmpyGallows();
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
                    PrintEmpyGallows();
                    break;
            }
        }
    }
}
