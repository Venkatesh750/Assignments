using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Practice1
{
    public class demo
    {
        public void Fn()
        {
            FileStream f = new FileStream("C:\\Users\\ELCOT\\Desktop\\sample1.txt",FileMode.OpenOrCreate);
            BinaryFormatter b = new BinaryFormatter();

            Console.WriteLine("Enter your name : ");
            string value = Console.ReadLine();

            Console.WriteLine("Enter your acc no. ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your bal : ");
            int balance = int.Parse(Console.ReadLine());

            Se s = new Se(value, a, balance); 
            b.Serialize(f, s);
            f.Close();
        }

        public void Fn1()
        {
            FileStream fs = new FileStream("C:\\Users\\ELCOT\\Desktop\\sample1.txt", FileMode.OpenOrCreate);
            BinaryFormatter bf = new BinaryFormatter();
            Se s = (Se)bf.Deserialize(fs);
            Console.WriteLine("Your name : {0} \nYour acc no. {1} \nYour acc bal : {2}",s.a_name,s.a_no,s.bal);
            fs.Close();
        }
    }
}
