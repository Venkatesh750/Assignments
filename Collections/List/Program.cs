using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace list
{
    class Program
    {
        static void Main(string[] args)
        {
            // List<T> class represents the list of objects which can be accessed by index

            // calling the method
            lst();
        }

        // creating a method for list
        public static void lst()
        {
            // creating a list as string type
            List<string> lt = new List<string>();

            // adding the values to the string
            lt.Add("Hello!!");
            lt.Add("Venkatesh");

            // print the values using foreach
            foreach(string val in lt)
            {
                Console.WriteLine(val);
            }
        }
    }
}
