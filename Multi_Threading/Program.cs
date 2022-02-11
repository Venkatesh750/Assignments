using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Multi_Threading
{
    class Program
    {
        static void Main(string[] args)
        {
            // creating threads
            Thread th = new Thread(Func1);
            Thread th1 = new Thread(Func2);

            // starting the threads
            th.Start();
            th1.Start();
        }

        // method1 .. it is printing the numbers from 1 to 10
        public static void Func1()
        {
            for (int i = 1; i <= 10; i++)
            {
                if (i == 2)
                {
                    // if condition is true then it will wait for 4 milliseconds
                    Thread.Sleep(4000);
                }
                Console.WriteLine("Function 1 : " + i);
            }
        }

        // method2 .. it is printing the numbers from 1 to 10
        public static void Func2()
        {
            for (int j = 1; j <= 10; j++)
            {
                if (j == 2)
                {
                    // if condition is true then it will wait for 6 milliseconds
                    Thread.Sleep(6000);
                }
                Console.WriteLine("Function 2 : " + j);
            }
        }
    }
}
