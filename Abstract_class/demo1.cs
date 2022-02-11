using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_class
{
    public class demo1 : demo
    {
        public override void fn1()
        {
            fn2();
            Console.WriteLine("This is an abstract method!!");
        }
        
    }
}
