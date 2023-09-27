using System;
class Calculator
{
    static void Main(string[] args)
    {
        Console.WriteLine("Выберите действие");
        Console.WriteLine("1. Сложение");
        Console.WriteLine("2. Вычитание");
        Console.WriteLine("3. Умножение");
        Console.WriteLine("4. Деление");
        Console.WriteLine("5. Возвести в степень");
        Console.WriteLine("6. Вычислить квадратный корень");
        Console.WriteLine("7. Найти 1 процент от числа");
        Console.WriteLine("8. Вычислить факториал");
        Console.WriteLine("9. Выйти из программы");
        int operation;
        while (true)
        {
            if (!int.TryParse(Console.ReadLine(), out operation))
            {
                Console.WriteLine("Ошибка");
                continue;
            }
            if (operation == 9)
                break;
            double num1, num2, res;
            switch (operation)
            {
                case 1:
                    Console.Write("Введите первое число: ");
                    if (!double.TryParse(Console.ReadLine(), out num1))
                    {
                        Console.WriteLine("Ошибка");
                        continue;
                    }

                    Console.Write("Введите второе число: ");
                    if (!double.TryParse(Console.ReadLine(), out num2))
                    {
                        Console.WriteLine("Ошибка");
                        continue;
                    }

                    res = num1 + num2;
                    Console.WriteLine($"Ответ: {res}");
                    break;
                case 2:
                    Console.Write("Введите первое число: ");
                    if (!double.TryParse(Console.ReadLine(), out num1))
                    {
                        Console.WriteLine("Ошибка");
                        continue;
                    }

                    Console.Write("Введите второе число: ");
                    if (!double.TryParse(Console.ReadLine(), out num2))
                    {
                        Console.WriteLine("Ошибка");
                        continue;
                    }

                    res = num1 - num2;
                    Console.WriteLine($"Ответ: {res}");
                    break;
                case 3:
                    Console.Write("Введите первое число: ");
                    if (!double.TryParse(Console.ReadLine(), out num1))
                    {
                        Console.WriteLine("Ошибка");
                        continue;
                    }

                    Console.Write("Введите второе число: ");
                    if (!double.TryParse(Console.ReadLine(), out num2))
                    {
                        Console.WriteLine("Ошибка");
                        continue;
                    }

                    res = num1 * num2;
                    Console.WriteLine($"Ответ: {res}");
                    break;
                case 4:
                    Console.Write("Введите первое число: ");
                    if (!double.TryParse(Console.ReadLine(), out num1))
                    {
                        Console.WriteLine("Ошибка");
                        continue;
                    }

                    Console.Write("Введите второе число: ");
                    if (!double.TryParse(Console.ReadLine(), out num2) || num2 == 0)
                    {
                        Console.WriteLine("Ошибка");
                        continue;
                    }

                    res = num1 / num2;
                    Console.WriteLine($"Ответ: {res}");
                    break;
                case 5:
                    Console.Write("Введите число: ");
                    if (!double.TryParse(Console.ReadLine(), out num1))
                    {
                        Console.WriteLine("Ошибка");
                        continue;
                    }

                    Console.Write("Введите степень: ");
                    int stepen;
                    if (!int.TryParse(Console.ReadLine(), out stepen))
                    {
                        Console.WriteLine("Ошибка! Введите целое число.");
                        continue;
                    }

                    res = Math.Pow(num1, stepen);
                    Console.WriteLine($"Ответ {res}");
                    break;
                case 6:
                    Console.Write("Введите число: ");
                    if (!double.TryParse(Console.ReadLine(), out num1) || num1 < 0)
                    {
                        Console.WriteLine("Ошибка");
                        continue;
                    }

                    res = Math.Sqrt(num1);
                    Console.WriteLine($"Ответ: {res}");
                    break;
                case 7:
                    Console.Write("Введите число: ");
                    if (!double.TryParse(Console.ReadLine(), out num1))
                    {
                        Console.WriteLine("Ошибка");
                        continue;
                    }

                    res = num1 * 0.01;
                    Console.WriteLine($"Ответ: {res}");
                    break;
                case 8:
                    Console.Write("Введите число: ");
                    if (!int.TryParse(Console.ReadLine(), out int factorialNumber) || factorialNumber < 0)
                    {
                        Console.WriteLine("Ошибка");
                        continue;
                    }
                    res = 1;
                    for (int i = 2; i <= factorialNumber; i++)
                    {
                        res *= i;
                    }
                    Console.WriteLine($"Ответ {res}");
                    break;

                default:
                    Console.WriteLine("Ошибка");
                    break;
            }

        }
        Console.WriteLine("Завершено");
    }
}
