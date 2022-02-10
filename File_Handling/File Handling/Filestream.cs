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
            FileStream show = new FileStream("C:\\Users\\ELCOT\\Desktop\\FS.txt", FileMode.OpenOrCreate);
            show.WriteByte(89);
            show.Close();
        }
        
    }
}
