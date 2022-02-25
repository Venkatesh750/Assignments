using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Practice1 
{
    class Program 
    {
        static void Main(string[] args)
        {
            //FileInfo
            File_Info display = new File_Info();
            display.Fun();

            //Serializable
            demo obj = new demo();
            obj.Fn();
            obj.Fn1();
            Console.ReadKey();
        }
    }
}
