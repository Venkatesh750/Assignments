using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_class
{
    // An abstract class is a special type of class that cannot be instantiated

    public abstract class demo
    {
        // An Abstract method is a method without a body
        public abstract void fn1();

        // normal method
        public static void fn2()
        {
            Console.WriteLine("This is normal method!!");
        }
        
    }
}
