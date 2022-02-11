using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            // creating an object
            Interface1 obj = new demo();

            // calling the two methods
            obj.fn1();
            obj.fn2();

        }
    }
}
