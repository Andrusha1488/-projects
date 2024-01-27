using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.SqlServer.Server;
using System.Security.Cryptography;

namespace ConsoleApp22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool trigger2 = true;
            while (trigger2)
            {

                Console.CursorVisible = false;
                Menu Start = new Menu(new List<string> { "Форма торта", "Размер торта", "Вкус коржей", "Количество коржей", "Глазурь", "Декор", "Конец заказа" });
                Menu Second = new Menu();
                ArrowMenu Knopochki = new ArrowMenu();
                int minY = 3;
                int pos1; // выбранное положение главного меню
                int pos2; // выбранное положение второстепенного меню
                string[] Zakaz = { "", "", "", "", "", "" };
                int Summa = 0;
                bool trigger = true;

                while (trigger)
                {
                    Start.PrintSpisok(ref minY, Zakaz, ref Summa);                        // вывели на экран стартовое меню
                    pos1 = Knopochki.Arrow(minY, Start.options.Count); // в пос1 хранится наш выбор

                    List<string> list = new List<string>();
                    switch (pos1)
                    {
                        case 0:
                            list = new List<string> { "Круг - 500", "Квадрат - 500", "Прямоугольник - 500", "Сердечко - 700" };
                            break;
                        case 1:
                            list = new List<string> { "Маленький - 1000", "Средний - 1200", "Большой - 2000" };
                            break;
                        case 2:
                            list = new List<string> { "Ванильный - 100", "Шоколадный - 100", "Карамельный - 150", "Ягодный - 200", "Кокосовый - 250" };
                            break;
                        case 3:
                            list = new List<string> { "Один Корж - 200", "Два Коржа - 400", "Три Коржа - 600", "Четыре Коржа - 800" };
                            break;
                        case 4:
                            list = new List<string> { "Шоколад - 100", "Крем - 100", "Безе - 150", "Драже - 150", "Ягоды - 200" };
                            break;
                        case 5:
                            list = new List<string> { "Шоколадный - 150", "Ягодный - 150", "Кремовый - 150" };
                            break;
                        case 6:
                            trigger = false;
                            break;
                    }
                    if (trigger == true)
                    {
                        Second.options = list;
                        Second.PrintSpisok(ref minY, Zakaz, ref Summa);
                        pos2 = Knopochki.Arrow(minY, Second.options.Count);
                        Zakaz[pos1] = Second.options[pos2];
                    }

                }
                string txt = "Ваш заказ: ";
                for (int i = 0; i < Zakaz.Length; i++)
                {
                    txt += Zakaz[i] + " ";
                }



                File.AppendAllText("C:\\Users\\Admin\\Desktop\\MyText.txt", txt);
                File.AppendAllText("C:\\Users\\Admin\\Desktop\\MyText.txt", $"\nСумма заказа: {Summa}\n");

                Console.Clear();
                Console.WriteLine("Ваш заказ принят и записан в файл. Будете делать еще заказ?");
                Console.WriteLine("1 - да \n2 - нет");
                int choice;
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:

                        break;
                    case 2:
                        trigger2 = false;
                        break;
                }





            }
        }
    }
}
