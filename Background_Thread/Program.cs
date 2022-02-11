using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Types_of_Thread
{
    class Program
    {
        static void Main(string[] args)
        {
            // create an instance of thread
            Thread th = new Thread(fn1);
            
            // set the thread as in background
            th.IsBackground = true;
            th.Start();
            
            // main method end
            Console.WriteLine("Main method ends");
        }
           
        // creating a method fn1
        public static void fn1()
        {
            Console.WriteLine("Function 1");
            Thread.Sleep(4000);
            Console.WriteLine("Function ends");
        }
    }
    
}
