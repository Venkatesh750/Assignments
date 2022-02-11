using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Thread_Priority
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread th1 = new Thread(Display1);
            Thread th2 = new Thread(Display2);
            Thread th3 = new Thread(Display3);

            th1.Priority = ThreadPriority.Normal;
            th2.Priority = ThreadPriority.Lowest;
            th3.Priority = ThreadPriority.Highest;

            th1.Start();
            th2.Start();
            th3.Start();

        }
        public static void Display1()
        {
            Console.WriteLine("This is Display1 method");
        }

        public static void Display2()
        {
            Console.WriteLine("This is Display2 method");
        }

        public static void Display3()
        {
            Console.WriteLine("This is Display3 method");
        }
    }
}
