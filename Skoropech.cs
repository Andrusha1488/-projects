using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;
using System.IO;

namespace ConsoleApp27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char charKey;

            Console.CursorVisible = false;
            Test test01 = new Test();
            Thread ThreadTimer = new Thread(_ =>
            {
                MyTimer timer = new MyTimer();
                int Stop = 0;
                bool StopTimer = true;

                while (StopTimer)
                {
                    if (timer.Seconds() == 0)
                    {
                        StopTimer = false;
                    }

                }
            });
            //ThreadTimer.Start();                      //если тут снять комментирование, то таймер работает, но странно

            while (true)
            {

                test01.PrintTest();

                ConsoleKeyInfo key = Console.ReadKey(true);
                charKey = Convert.ToChar(key.KeyChar);

                if (charKey == test01.charTest[test01.pos])
                {
                    test01.pos++;
                }

            }

        }


    }
}
