using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Practice
{
    class TW_TR
    {
        public void display3()
        {
            using (TextWriter tw = File.CreateText("C:\\Users\\ELCOT\\Desktop\\TW_TR.txt"))
            {
                tw.WriteLine("Venkatesh");
                
            }
        }
        public void display4()
        {
            using (TextReader tw = File.OpenText("C:\\Users\\ELCOT\\Desktop\\TW_TR.txt"))
            {
               Console.WriteLine("Good Afternoon..");

            }
        }

    }
}
