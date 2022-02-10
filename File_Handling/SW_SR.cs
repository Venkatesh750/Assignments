using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Practice
{
    class SW_SR
    {
        public void display1()
        {
            FileStream f = new FileStream("C:\\Users\\ELCOT\\Desktop\\SW_SR.txt", FileMode.OpenOrCreate);
            StreamWriter sw = new StreamWriter(f);

            sw.WriteLine("Hello");
            sw.Close();
            f.Close();
        }

        public void display2()
        {
            FileStream FS = new FileStream("C:\\Users\\ELCOT\\Desktop\\SW_SR.txt", FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(FS);

            string value = sr.ReadLine();
            Console.WriteLine("Good Morning..");
            sr.Close();
            sr.Close();
        }
    }
}
