using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp27
{
    internal class Test
    {
        public char[] charTest;
        public string path;
        public int testLength;
        public int pos = 0;

        public Test()
        {
            path = "1.txt";
            string test = File.ReadAllText(path);
            testLength = test.Length;
            charTest = new char[testLength];


            for (int i = 0; i < testLength; i++)
            {
                charTest[i] = test[i];

            }
        }

        public void PrintTest()
        {
            ConsoleColor def = Console.BackgroundColor;
            Console.SetCursorPosition(0, 3);
            for (int i = 0; i < testLength; i++)
            {
                if(i< pos)
                {
                    Console.BackgroundColor = ConsoleColor.Magenta;
                    Console.Write(charTest[i]);
                }    
                else
                {
                    Console.BackgroundColor = def;
                    Console.Write(charTest[i]);
                }
            }
        }
    }
}
