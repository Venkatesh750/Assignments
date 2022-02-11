using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            // creating a thread
            Thread th1 = new Thread(fun1);
            Thread th2 = new Thread(fun2);
            Thread th3 = new Thread(fun3);
            Thread th4 = new Thread(fun4);
            Thread th5 = new Thread(fun5);
            
            // Print the 5 priority choices and get the priority value from user
            Console.WriteLine("Enter your prority .. \n Highest - 4 \n AboveNormal - 3 \n Normal - 2 \n BelowNormal - 1 \n Lowest - 0 ");
            int num = int.Parse(Console.ReadLine());
            
            // condition to check the value from user and start the thread
            if(num == 4)
            {
                th1.Priority = ThreadPriority.Highest;
                th1.Start();
            }
            else if (num == 3)
            {
                th2.Priority = ThreadPriority.AboveNormal;
                th2.Start();
            }
            else if (num == 2)
            {
                th3.Priority = ThreadPriority.Normal;
                th3.Start();
            }
            else if (num == 1)
            {
                th4.Priority = ThreadPriority.BelowNormal;
                th4.Start();
            }
            else
            {
                th5.Priority = ThreadPriority.Lowest;
                th5.Start();
            }
            Console.ReadKey();
        }
        
        // methods for display to the user
        public static void fun1()
        {
            Console.WriteLine("You entered the Highest Priority");
        }

        public static void fun2()
        {
            Console.WriteLine("You entered the AboveNormal Priority");
        }

        public static void fun3()
        {
            Console.WriteLine("You entered the Normal Priority");
        }
        public static void fun4()
        {
            Console.WriteLine("You entered the BelowNormal Priority");
        }
        public static void fun5()
        {
            Console.WriteLine("You entered the Lowest Priority");
        }
    }
}
