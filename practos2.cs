using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float a;
            float b;
            float c;
            float e = 1;
            int operation =0;

            while (operation != 9)
            {

                Console.WriteLine("Добро пожаловать в калькулятор! Что вы хотите сделать?");
            Console.WriteLine("1. Сложение двух чисел");
            Console.WriteLine("2. Вычитание одного числа из другого");
            Console.WriteLine("3. Перемножение двух чисел");
            Console.WriteLine("4. Деление двух чисел");
            Console.WriteLine("5. Возведение первого числа в степень второго");
            Console.WriteLine("6. Квадратный корень числа");
            Console.WriteLine("7. Найти один процент от числа");
            Console.WriteLine("8. Факториал числа");
            Console.WriteLine("9. Выйти из программы");
            operation = Convert.ToInt32(Console.ReadLine());

            
            
                switch (operation)
                {
                    case 1:
                        Console.WriteLine("Введите первое число: ");
                        a = Convert.ToSingle(Console.ReadLine());
                        Console.WriteLine("Введите второе число: ");
                        b = Convert.ToSingle(Console.ReadLine());
                        Console.WriteLine($"Сумма {a} и {b} равна {a + b}");
                        break;

                    case 2:
                        Console.WriteLine("Введите первое число: ");
                        a = Convert.ToSingle(Console.ReadLine());
                        Console.WriteLine("Введите второе число: ");
                        b = Convert.ToSingle(Console.ReadLine());
                        Console.WriteLine($"Разность {a} и {b} равна {a - b}");
                        break;

                    case 3:
                        Console.WriteLine("Введите первое число: ");
                        a = Convert.ToSingle(Console.ReadLine());
                        Console.WriteLine("Введите второе число: ");
                        b = Convert.ToSingle(Console.ReadLine());
                        Console.WriteLine($"Произведение {a} и {b} равно {a * b}");
                        break;

                    case 4:
                        Console.WriteLine("Введите первое число: ");
                        a = Convert.ToSingle(Console.ReadLine());
                        Console.WriteLine("Введите второе число: ");
                        b = Convert.ToSingle(Console.ReadLine());
                        if (b == 0)
                        {
                            Console.WriteLine("Ошибка. На ноль делить нельзя.");
                        }
                        Console.WriteLine($"Частное {a} и {b} равна {a / b}");
                        break;

                    case 5:
                        Console.WriteLine("Введите число: ");
                        a = Convert.ToSingle(Console.ReadLine());
                        Console.WriteLine("Введите степень числа: ");
                        b = Convert.ToSingle(Console.ReadLine());
                        Console.WriteLine($"Число {a} в степени {b} равно {Math.Pow(a, b)}");
                        break;

                    case 6:
                        Console.WriteLine("Введите число: ");
                        a = Convert.ToSingle(Console.ReadLine());
                        if (a >= 0)
                        {
                            Console.WriteLine($"Квадратный корень {a} равен {Math.Sqrt(a)}");
                        }
                        else
                        {
                            Console.WriteLine("Ошибка. Из отрицательного числа корень не выводится");
                        }
                        break;

                    case 7:
                        Console.WriteLine("Введите число: ");
                        a = Convert.ToSingle(Console.ReadLine());
                        Console.WriteLine($"Один процент от числа {a} равен {a * 0,01}");
                        break;

                    case 8:
                        float d;
                        Console.WriteLine("Введите число: ");
                        a = Convert.ToSingle(Console.ReadLine());
                        c = a;
                        while (c > 0)
                        {
                            e *= c;
                            c--;
                        }
                        Console.WriteLine($"Факториал числа {a} равен {e}");
                        e = 1;
                        break;

                    case 9:
                        break;

                    default:
                        Console.WriteLine("такой операции нет в списке.");
                        break;
                }

            }
        }
    }
}
