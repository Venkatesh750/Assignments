using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Practice1
{
    public class File_Info
    {
        
       public void Fun()
        {
            try
            {
                string path = "C:\\Users\\ELCOT\\Desktop\\sample.txt";
                FileInfo obj = new FileInfo(path);
                StreamWriter s1 = obj.CreateText();

                Console.WriteLine("Enter the text ..");
                string val = Console.ReadLine();
                s1.WriteLine(val);
                Console.WriteLine(s1);
            }
            catch(Exception e)
            {
                Console.WriteLine("Error is : "+e); 
            }
        }
    }
}
