using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Stk
{
    class Program
    {
        static void Main(string[] args)
        {
            // Stack stores elements in LIFO style (Last In First Out)

            // calling the method
            stk();
        }

        public static void stk()
        {
            // creating a stack
            Stack sk = new Stack();

            // pushing the value into the stack (add)
            sk.Push("Venkatesh");
            sk.Push("I\'m");
            sk.Push("Hello!!");

            // popping the value from the stack (remove)
            sk.Pop();

            // print the values from the stack
            foreach(object val in sk)
            {
                Console.WriteLine(val);
            }
        }
    }
}
