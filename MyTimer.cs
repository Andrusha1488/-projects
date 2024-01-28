using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApp27
{
    internal class MyTimer
    {
        public int StartTime;

        public MyTimer()
        {
            StartTime = 60;
        }

        public int Seconds()
        {
            
            Console.SetCursorPosition(0,0);
            

            StartTime--;
            Console.WriteLine("Таймер теста: " + StartTime + "  ");
            
            Console.Beep(600, 100);
            Thread.Sleep(1000);
            return StartTime;
        }
        
    }
}
