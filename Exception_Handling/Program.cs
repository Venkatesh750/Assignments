using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling
{
    class Program
    {
        static void Main(string[] args)
        {
            // initializing the value for x
            int x = 0;

            // creating a variable y as integer
            int y;

            // Exception Handling

            // try block holds the code that may throw an exception
            try
            {
                y = 10 / x;
            }

            // catch block catches the exception thrown by the try block
            catch (DivideByZeroException)
            {
                Console.WriteLine("Exception occured");
            }

            // This block holds the default code
            finally
            {
                Console.WriteLine("Finally Block");
            }
        }
    }
}
