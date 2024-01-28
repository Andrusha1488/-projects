
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;
using ConsoleApp25;

namespace Zmeyka
{
    internal class Limits
    {

        public int maxX;
        public int maxY;
        //string path = "map.txt";
        char[,] map = null;
        public void SizeMap()                               //определяет максимум и минимум и массив карты
        {
            string path = "map.txt";
            string[] massiveTxt = File.ReadAllLines(path);
            maxX = massiveTxt.Length;
            maxY = massiveTxt[0].Length;

            map = new char[maxX, maxY];
            for (int i = 0; i < maxX; i++)
            {
                for (int j = 0; j < maxY; j++)
                {
                    map[i, j] = massiveTxt[i][j];
                }
            }
        }

        public void PrintMap()
        {
            Console.SetCursorPosition(0, 0);
            for (int x = 0; x < maxX; x++)
            {
                for (int y = 0; y < maxY; y++)
                {
                    Console.Write(map[x, y]);
                }
                Console.WriteLine();
            }

        }

        public void SnakeFood(int eats, char food, Snake snake, int X, int Y)
        {
            int TempX;
            int TempY;
            Random rnd = new Random();
                TempX = rnd.Next(1, maxX - 1);
                TempY = rnd.Next(1, maxY - 1);
            for (int x = 0; x < eats; x++)
            {
                bool trigger3 = true;
                while (trigger3)
                {
                    trigger3 = false;
                    TempX = rnd.Next(1, maxX - 1);
                    TempY = rnd.Next(1, maxY - 1);


                    //Console.SetCursorPosition(rnd.Next(1, maxY), rnd.Next(1, maxX));
                    //Console.WriteLine(a);
                    for (int y = 0; y < snake.snake.GetLength(0); y++)
                    {
                        if (TempX == snake.snake[y, 0] + Y && TempY == snake.snake[y, 1] + X)
                        {
                            //еда хочет поставиться на змейку - ищем координаты дальше
                            trigger3 = true;
                        }
                    
                    }

                }
                            map[TempX, TempY] = food;
            }


        }

        public int ScoreUp(int X, int Y, char food)            //ем еду
        {
            if (map[Y, X] == food)
            {
                Thread thread = new Thread(_ =>
                {

                    Console.Beep(1000, 200);
                });
                thread.Start();
                map[Y, X] = ' ';
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public void SnakeScore(int Score, int level, int record)
        {

            Console.SetCursorPosition(maxY + 1, 0);
            Console.Write($"Текущий уровень: {level}");
            Console.SetCursorPosition(maxY + 1, 1);
            Console.Write($"Score: {Score}");
            Console.SetCursorPosition(maxY + 1, 3);
            Console.Write($"Текущий рекорд: {record}");

        }

        public bool Proverka(int X, int Y)
        {
            if (map[Y, X] == '#')
            {
                return false;
            }

            else return true;
        }

        public void Bag01(int X, int Y, char food)
        {
            if (map[Y, X] == food)
            {
                Console.SetCursorPosition(X, Y);
                Console.Write(food);
            }
        }

    }

}
