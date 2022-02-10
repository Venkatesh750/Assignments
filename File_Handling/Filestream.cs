using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Practice
{
    class Filestream
    {
        public void display()
        {
            FileStream fs = new FileStream("C:\\Users\\ELCOT\\Desktop\\FS.txt", FileMode.OpenOrCreate);
            fs.WriteByte(89);
            fs.Close();
        }
        
    }
}
