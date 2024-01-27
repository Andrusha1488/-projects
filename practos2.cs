using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice;
            bool y = true;
            while (y)
            {
                Console.WriteLine("Выберите программу:");
                Console.WriteLine("1 - угадай число ");
                Console.WriteLine("2 - таблица умножения");
                Console.WriteLine("3 - делители числа");
                Console.WriteLine("4 - выйти из программы");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:

                        Random rnd = new Random();
                        int number = rnd.Next(0, 101);
                        int tries;
                        

                        Console.WriteLine("загадано число от 1 до 100. Попробуй угадать!");

                        for (int i = 0; i < int.MaxValue; i++)
                        {
                            tries = Convert.ToInt32(Console.ReadLine());
                            if (tries > number)
                            {
                                Console.WriteLine("Нужно меньше");
                            }
                            else if (tries < number)
                            {
                                Console.WriteLine("Нужно больше");
                            }
                            else if (tries == number)
                            {
                                Console.WriteLine($"Молодец! Ты угадал число {number} за {i + 1} попыток");
                                break;
                            }
                        }

                    break;





                    case 2:

                        int[,] mnoj = new int[9, 9];

                        for (int j = 0; j < mnoj.GetLength(0); j++)
                        {
                            for (int k = 0; k < mnoj.GetLength(1); k++)
                            {
                                if (j == 0 || k == 0)
                                {
                                    mnoj[k, j] = (j + 1) * (k + 1); //пустая таблица умножения
                                }
                            }

                        }

                        //теперь перемножение

                        for (int j = 0; j < mnoj.GetLength(0); j++)
                        {
                            for (int k = 0; k < mnoj.GetLength(1); k++)
                            {
                                if (j != 0 || k != 0)
                                {
                                    mnoj[k, j] = (j + 1) * (k + 1);
                                }
                                Console.Write(mnoj[k, j] + "\t");
                            }
                            Console.WriteLine();
                        }
                        break;





                    case 3:
                        int a;

                        Console.WriteLine("Введите целое число: ");
                        a = Convert.ToInt32(Console.ReadLine());

                        Console.Write($"Делители числа {a}: ");

                        for (int j = a; j != 0; j--)
                        {
                            if (a % j == 0)
                            {
                                Console.Write($" {j} ");
                            }
                        }
                        break;

                    case 4:
                        y = false;
                        break;

                    default:
                        Console.WriteLine("Такой программы нет в списке!");
                        break;

                }
            }
        }
    }
}
