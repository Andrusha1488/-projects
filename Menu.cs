using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{
    internal class Menu
    {
        public List<string> options;
        


        public Menu(List<string> tempList)  // конструктор на лист в скобке
        {
            options = tempList;
            //for (int i = 0; i < tempList.Count; i++)
            //{
            //    options.Add(tempList[i]);
            //}
        }
        public Menu()
        {
            options = new List<string>();
        }

        public void PrintSpisok(ref int minY, string[] Zakaz,ref int Summa)
        {
            Console.Clear();

            Console.WriteLine("Добро пожаловать в нашу пекарню 'Булочки'.\nЧто хотите заказать?");

            for (int i = 0;i < options.Count;i++)
            {
                Console.SetCursorPosition(4, minY+i);
                Console.Write(options[i]);
            }

            Console.SetCursorPosition(0, 20);
            Console.Write("Ваш заказ: ");
            for (int i = 0; i < Zakaz.Length; i++)
            {
                Console.Write(Zakaz[i] + " ");

            }

            Console.SetCursorPosition(0, 21);
            Summa = 0;
            for (int i = 0; i < Zakaz.Length; i++)
            {
                int value;
                int.TryParse(string.Join("", Zakaz[i].Where(c => char.IsDigit(c))), out value);
                Summa += value;
            }
            Console.Write($"Сумма заказа: {Summa}");

        }


    }




}
