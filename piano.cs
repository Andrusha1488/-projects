using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 октава - F1, 2 октава - F2, 3 октава - F3");
            int ps;
            int[,] StartPos =
            {
                {3, 8},
                {5, 2},
                {7, 8},
                {9, 2},
                {11, 8},
                {15, 8},
                {17, 2},
                {19, 8},
                {21, 2},
                {23, 8},
                {25, 2},
                {27, 8},
            };

            float[] octave0 = { 261.6f, 277.2f, 293.7f, 311.1f, 329.6f, 349.2f, 369.9f, 391.9f, 415.3f, 440f, 466.2f, 493.9f };
            float[] octave1 = { 523.2f, 554.4f, 587.3f, 622.2f, 659.2f, 698.4f, 739f, 783f, 830.6f, 880f, 932.3f, 987.7f};
            float[] octave2 = { 1046.5f, 1108.7f, 1174.6f, 1244.5f, 1318.5f, 1396.9f, 1479f, 1567f, 1661.2f, 1760f, 1864.6f, 1975.5f};
            float[] octaves = new float[12];
            octaves = octave0;
            ConsoleColor[] color = {ConsoleColor.Green, ConsoleColor.Red, ConsoleColor.Green, ConsoleColor.Red, ConsoleColor.Green, ConsoleColor.Green, ConsoleColor.Red, ConsoleColor.Green, ConsoleColor.Red, ConsoleColor.Green, ConsoleColor.Red, ConsoleColor.Green };
            char[] Ltr = { 'S', 'E','D','R','F','G','Y','H','U','J','I','K' };
            ConsoleColor Press = ConsoleColor.DarkMagenta;


            for (int i = 0; i < StartPos.GetLength(0); i++)
            {
                    KeyPos(StartPos[i, 0], StartPos[i, 1], color[i], Ltr[i]);

            }
            Console.SetCursorPosition(0, 20);


            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Black;
                Console.SetCursorPosition(0, 20);

                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.S:
                        ps = 0;
                        Console.Beep(Convert.ToInt32(octaves[ps]), 500);
                        KeyPos(StartPos[ps, 0], StartPos[ps, 1], Press, Ltr[ps]);
                        System.Threading.Thread.Sleep(300);
                        KeyPos(StartPos[ps, 0], StartPos[ps, 1], color[ps], Ltr[ps]);
                        break;

                    case ConsoleKey.E:
                        ps = 1;
                        Console.Beep(Convert.ToInt32(octaves[ps]), 500);
                        KeyPos(StartPos[ps, 0], StartPos[ps, 1], Press, Ltr[ps]);
                        System.Threading.Thread.Sleep(300);
                        KeyPos(StartPos[ps, 0], StartPos[ps, 1], color[ps], Ltr[ps]);
                        break;

                    case ConsoleKey.D:
                        ps = 2;
                        Console.Beep(Convert.ToInt32(octaves[ps]), 500);
                        KeyPos(StartPos[ps, 0], StartPos[ps, 1], Press, Ltr[ps]);
                        System.Threading.Thread.Sleep(300);
                        KeyPos(StartPos[ps, 0], StartPos[ps, 1], color[ps], Ltr[ps]);
                        break;

                    case ConsoleKey.R:
                        ps = 3;
                        Console.Beep(Convert.ToInt32(octaves[ps]), 500);
                        KeyPos(StartPos[ps, 0], StartPos[ps, 1], Press, Ltr[ps]);
                        System.Threading.Thread.Sleep(300);
                        KeyPos(StartPos[ps, 0], StartPos[ps, 1], color[ps], Ltr[ps]);
                        break;

                    case ConsoleKey.F:
                        ps = 4;
                        Console.Beep(Convert.ToInt32(octaves[ps]), 500);
                        KeyPos(StartPos[ps, 0], StartPos[ps, 1], Press, Ltr[ps]);
                        System.Threading.Thread.Sleep(300);
                        KeyPos(StartPos[ps, 0], StartPos[ps, 1], color[ps], Ltr[ps]);
                        break;

                    case ConsoleKey.G:
                        ps = 5;
                        Console.Beep(Convert.ToInt32(octaves[ps]), 500);
                        KeyPos(StartPos[ps, 0], StartPos[ps, 1], Press, Ltr[ps]);
                        System.Threading.Thread.Sleep(300);
                        KeyPos(StartPos[ps, 0], StartPos[ps, 1], color[ps], Ltr[ps]);
                        break;

                    case ConsoleKey.Y:
                        ps = 6;
                        Console.Beep(Convert.ToInt32(octaves[ps]), 500);
                        KeyPos(StartPos[ps, 0], StartPos[ps, 1], Press, Ltr[ps]);
                        System.Threading.Thread.Sleep(300);
                        KeyPos(StartPos[ps, 0], StartPos[ps, 1], color[ps], Ltr[ps]);
                        break;

                    case ConsoleKey.H:
                        ps = 7;
                        Console.Beep(Convert.ToInt32(octaves[ps]), 500);
                        KeyPos(StartPos[ps, 0], StartPos[ps, 1], Press, Ltr[ps]);
                        System.Threading.Thread.Sleep(300);
                        KeyPos(StartPos[ps, 0], StartPos[ps, 1], color[ps], Ltr[ps]);
                        break;

                    case ConsoleKey.U:
                        ps = 8;
                        Console.Beep(Convert.ToInt32(octaves[ps]), 500);
                        KeyPos(StartPos[ps, 0], StartPos[ps, 1], Press, Ltr[ps]);
                        System.Threading.Thread.Sleep(300);
                        KeyPos(StartPos[ps, 0], StartPos[ps, 1], color[ps], Ltr[ps]);
                        break;

                    case ConsoleKey.J:
                        ps = 9;
                        Console.Beep(Convert.ToInt32(octaves[ps]), 500);
                        KeyPos(StartPos[ps, 0], StartPos[ps, 1], Press, Ltr[ps]);
                        System.Threading.Thread.Sleep(300);
                        KeyPos(StartPos[ps, 0], StartPos[ps, 1], color[ps], Ltr[ps]);
                        break;
                    case ConsoleKey.I:
                        ps = 10;
                        Console.Beep(Convert.ToInt32(octaves[ps]), 500);
                        KeyPos(StartPos[ps, 0], StartPos[ps, 1], Press, Ltr[ps]);
                        System.Threading.Thread.Sleep(300);
                        KeyPos(StartPos[ps, 0], StartPos[ps, 1], color[ps], Ltr[ps]);
                        break;

                    case ConsoleKey.K:
                        ps = 11;
                        Console.Beep(Convert.ToInt32(octaves[ps]), 500);
                        KeyPos(StartPos[ps, 0], StartPos[ps, 1], Press, Ltr[ps]);
                        System.Threading.Thread.Sleep(300);
                        KeyPos(StartPos[ps, 0], StartPos[ps, 1], color[ps], Ltr[ps]);
                        break;

                    case ConsoleKey.F1:
                        octaves = octave0;
                        break;
                    case ConsoleKey.F2:
                        octaves = octave1;
                        break;
                    case ConsoleKey.F3:
                        octaves = octave2;
                        break;
                }
                
            }
        }
        static void KeyPos(int pos1, int pos2, ConsoleColor color, char klav)
        {
                ConsoleColor defaultcolor = Console.BackgroundColor;
                Console.SetCursorPosition(pos1, pos2);
                Console.BackgroundColor = color;       //цвет клавиши
                Console.Write("   ");
                Console.SetCursorPosition(pos1, pos2 + 1);
                Console.Write($" {klav} ");
                Console.SetCursorPosition(pos1, pos2 + 2);
                Console.Write("   ");
                Console.SetCursorPosition(pos1, pos2 + 3);
                Console.Write("   ");
                Console.SetCursorPosition(pos1, pos2 + 4);
                Console.Write("   ");




                Console.BackgroundColor = defaultcolor;
        }
       
    }

}
