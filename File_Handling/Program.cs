using System;
using System.Collections;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating an object for FileStram -- To read and write a file
            Filestream obj = new Filestream();
            obj.display();

            
            SW_SR obj1 = new SW_SR();
            obj1.display1();

            obj1.display2();

            TW_TR obj3 = new TW_TR();
            obj3.display3();

            obj3.display4();
        } 
    }
}
