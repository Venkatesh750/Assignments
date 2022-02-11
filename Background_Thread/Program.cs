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
            Thread th = new Thread(fn1);
            th.IsBackground = true;
            th.Start();
            Console.WriteLine("Main method ends");
        }

        public static void fn1()
        {
            Console.WriteLine("Function 1");
            Thread.Sleep(4000);
            Console.WriteLine("Function ends");
        }
    }
    
}
