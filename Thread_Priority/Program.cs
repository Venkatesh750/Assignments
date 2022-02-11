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
            // creating an instance of thread
            Thread th1 = new Thread(Display1);
            Thread th2 = new Thread(Display2);
            Thread th3 = new Thread(Display3);
            
            // set the priority
            th1.Priority = ThreadPriority.Normal;
            th2.Priority = ThreadPriority.Lowest;
            th3.Priority = ThreadPriority.Highest;
            
            // starting the thread
            th1.Start();
            th2.Start();
            th3.Start();

        }
        
        // creating Display 1 method
        public static void Display1()
        {
            Console.WriteLine("This is Display1 method");
        }
        
        // creating Display 2 method
        public static void Display2()
        {
            Console.WriteLine("This is Display2 method");
        }

        // creating Display 3 method
        public static void Display3()
        {
            Console.WriteLine("This is Display3 method");
        }
    }
}
