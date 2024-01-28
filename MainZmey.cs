using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using ConsoleApp25;
using System.ComponentModel;
using Microsoft.SqlServer.Server;
using System.Data.OleDb;
using System.IO;

namespace Zmeyka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            int CurentX = 5;
            int CurentY = 5;
            char food = '*';
            int speed = 100;
            int eats = 0;                      // переменная дает 1 или 0 (съел еду или нет)
            int allEats = 10;
            int allEatsCount;
            int AllScore = 0;
            bool trigger = true;
            bool trigger2 = true;
            int[] lost;
            int[] Direction = new int[] { 0, 1 };
            int record = Convert.ToInt32(File.ReadAllLines("record.txt")[0]);

            int level = 0;

            Thread thread = new Thread(_ =>
            {
                while (true)
                {
                    Direction = KeyMove(Direction);

                }
            });
            thread.Start();


            Snake snake = new Snake();                     // определение начальной змейки с тремя элементами
            Limits border = new Limits();                 //определяет параметры карты(без конструктора пустой)
            

            while (trigger2)                                  //while ПЕРЕХОДА УРОВНЕЙ
            {
                trigger = true;
                trigger2 = true;
                ++level;
                allEatsCount = allEats;

                border.SizeMap();                             //определяет максимум и минимум и массив карты
                border.SnakeFood(allEats, food, snake, CurentX, CurentY);               // разбрасывает еду - заносит в массив (НЕ ПЕЧАТАТЕТ)
                border.PrintMap();                             // печать карты вместе с едой



                while (trigger && trigger2)
                {
                    snake.SnakePrint(CurentX, CurentY);              // рисует змейку 

                    if (Direction[0] != 0)                      //корректировка скорости по X и Y
                    {
                        Thread.Sleep(speed);

                    }
                    else
                    {
                        Thread.Sleep(speed * 2);
                    }


                    snake.SnakeClear(CurentX, CurentY);           // стирает змейку
                                                                  //Console.SetCursorPosition(0, 0);

                    CurentX += Direction[0];
                    CurentY += Direction[1];

                    trigger2 = border.Proverka(CurentX, CurentY);                // если змейка врезалась в стенку - выход из уровня

                    eats = border.ScoreUp(CurentX, CurentY, food);          // проверка на съедание еды, если съел 1 иначе 0
                    allEatsCount -= eats;
                    if (allEatsCount == 0)                                 // если мы съели всю еду то выходим из этого уровня
                    {
                        trigger = false;
                    }
                    if (eats != 0)
                    {

                        snake.SnakeGrow();                                 // съел еду - змейка выросла
                    }
                    //
                    lost = snake.SnakeMove(Direction);                          // пересчет массива в новые координаты
                    border.Bag01(lost[0] + CurentX, lost[1] + CurentY, food);
                    if (snake.SnakeNotItself())                          // если змейка врезается сама в себя то game over
                    {
                        trigger2 = false;

                    }


                    AllScore += eats;
                    if (AllScore > record)
                    {
                        record = AllScore;
                    }
                    border.SnakeScore(AllScore, level, record);

                }
                if (trigger || border.Proverka(CurentX, CurentY))
                {

                }
                Console.Clear();                                           // подготовка к новому уровню
                NewLevel(ref speed, ref allEats);

                if (!trigger2)
                {
                    Console.Clear();
                    Console.WriteLine("Игра окончена");
                    if (AllScore >= record)
                    {
                        File.WriteAllText("record.txt", Convert.ToString(AllScore));
                    }
                }
            }
        }
        static int[] KeyMove(int[] Direction)
        {
            int x = 0;
            int y = 0;
            ConsoleKeyInfo key = Console.ReadKey();
            switch (key.Key)
            {
                case ConsoleKey.UpArrow:
                    if (Direction[1] != 1)
                        y = -1;
                    else
                        y = 1;

                    break;
                case ConsoleKey.DownArrow:
                    if (Direction[1] != -1)
                        y = 1;
                    else
                        y = -1;
                    break;
                case ConsoleKey.LeftArrow:
                    if (Direction[0] != 1)
                        x = -1;
                    else x = 1;
                    break;
                case ConsoleKey.RightArrow:
                    if (Direction[0] != -1)
                        x = 1;
                    else
                    {

                        x = -1;
                    }
                    break;
                
            }
            Direction = new int[] { x, y };
            return Direction;
        }

        static void NewLevel(ref int speed, ref int allEats)
        {
            speed -= 10;
            allEats += 5;
        }


    }
}
