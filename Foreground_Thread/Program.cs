using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Foreground_Thread
{
    class Program
    {
        static void Main(string[] args)
        {
            // creating a thread
            Thread th = new Thread(fn1);

            // starting the thread
            th.Start();
            Console.WriteLine("Main thread ends");
        }

        // method for the looping process
        public static void fn1()
        {
            for (int i = 0; i <= 3; i++)
            {
                Console.WriteLine("Thread is in progress");

                // sleep the thread for 1 milliseconds
                Thread.Sleep(1000);
            }
            Console.WriteLine("Thread ends");
        }
    }
}
