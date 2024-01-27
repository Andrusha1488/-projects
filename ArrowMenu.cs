using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{
    internal class ArrowMenu
    {

        public int ArrowMax;
        public int ArrowMin;
       

        
        public int Arrow(int min, int count)
        {

            int pos = 0;
            
            ConsoleKeyInfo key = Console.ReadKey();
            while ( key.Key  != ConsoleKey.Enter)    // прогоняется пока не нажат энтер
            {
                Console.SetCursorPosition(0, min+pos);
                    Console.WriteLine("  ");
                if (key.Key == ConsoleKey.UpArrow && pos > 0) 
                {
                    pos--;
                }
                else if (key.Key == ConsoleKey.DownArrow && pos < count-1)
                {
                    pos++;
                }
                else if (key.Key == ConsoleKey.Escape)
                {
                    pos = 900;
                }

                Console.SetCursorPosition(0, min+pos);
                Console.WriteLine("->");

                key = Console.ReadKey();
            }
            return pos;
        }

    }
}
