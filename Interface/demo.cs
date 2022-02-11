using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class demo : Interface1
    {
        // Implementing the methods from interface
        void Interface1.fn1()
        {
            Console.WriteLine("This is method 1");
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine(i);
            }
        }

        void Interface1.fn2()
        {
            Console.WriteLine("This is method 2");
            for (int i = 0; i <= 10; i++)
            {
                if(i%2 == 0)
                {
                    Console.WriteLine(i);
                } 
            }
        }
    }
}
