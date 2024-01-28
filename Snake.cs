using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zmeyka;

namespace ConsoleApp25
{
    internal class Snake
    {
        public int[,] snake = new int[3, 2];
        public Snake()                                //конструктор по умолчанию делает координаты трех эл. змейки
        {
            for (int i = 0; i < 3; i++)
            {
                snake[i, 0] = -i;
                snake[i, 1] = 0;
            }
        }

        public void SnakeClear(int X, int Y)                               //очистка змейки
        {
            for (int i = 0; i < snake.GetLength(0); i++)
            {
                Console.SetCursorPosition(X + snake[i, 0], Y + snake[i, 1]);
                Console.Write(" ");
            }

        }

        public void SnakePrint(int X, int Y)                               //вывод змейки
        {

            for (int i = 0; i < snake.GetLength(0); i++)
            {
                Console.SetCursorPosition(X + snake[i, 0], Y + snake[i, 1]);
                Console.Write("O");
            }

        }

        public int[] SnakeMove(int[] direction)                      // сдвиг
        {
            int X = snake[snake.GetLength(0)-1, 0];
            int Y = snake[snake.GetLength(0)-1, 1];
             int[] lost = { X, Y };
            
            for (int i = snake.GetLength(0) - 2; i > 0; i--)            //цикл идет с предпоследнего элемента по первый
            {
                snake[i + 1, 0] = snake[i, 0] - direction[0];                  // сдвинул все элементы назад
                snake[i + 1, 1] = snake[i, 1] - direction[1];
            }
            snake[1, 0] = -direction[0];
            snake[1, 1] = -direction[1];
            return lost;

        }

        public void SnakeGrow()                                      //увеличение длины змейки
        { 
        
            int[,] TempSnake = new int[snake.GetLength(0) + 1, 2];
            for (int i = 0; i < snake.GetLength(0); i++)
            {
               TempSnake[i, 0] = snake[i, 0];
               TempSnake[i, 1] = snake[i, 1];

            }
            snake = TempSnake;
        }

        public bool SnakeNotItself()
        {
            
            bool TempItself = false;
            for (int i = 1;i < snake.GetLength(0); i++)
            {
                if (snake[i, 0] == 0 && snake[i, 1] == 0)
                {
                    TempItself = true;
                }

                
            }
            
            return TempItself;
        }
    }
}
