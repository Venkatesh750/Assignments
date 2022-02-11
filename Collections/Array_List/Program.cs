using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Array_List
{
    class Program
    {
        static void Main(string[] args)
        {
            // Arraylist is a class that is similar to an array

            // calling the method
            arlst();
        }

        public static void arlst()
        {
            // Creating an arraylist
            ArrayList arrlst = new ArrayList();

            // declaring the value for the variable
            string name = "Venkatesh";

            // adding two values
            int a, b, c;
            a = 10;
            b = 5;
            c = a + b;

            // adding the values that is stored in "name" and "c" to the arraylist
            arrlst.Add(name);
            arrlst.Add(c);

            // print the values in the arraylist
            foreach (object obj in arrlst)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
