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
            FileStream show = new FileStream("C:\\Users\\ELCOT\\Desktop\\SW_SR.txt", FileMode.OpenOrCreate);
            StreamWriter show1 = new StreamWriter(show);

            show1.WriteLine("Hello");
            show1.Close();
            show.Close();
        }

        public void display2()
        {
            FileStream show = new FileStream("C:\\Users\\ELCOT\\Desktop\\SW_SR.txt", FileMode.OpenOrCreate);
            StreamReader show2 = new StreamReader(show);

            string value = show2.ReadLine();
            Console.WriteLine("Good Morning..");
            show2.Close();
            show.Close();
        }
    }
}
