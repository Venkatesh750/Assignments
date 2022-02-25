using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Practice1
{
    [Serializable]
    public class Se
    {
        public string a_name;
        public int a_no,bal;
        public Se(string a_name, int a_no, int bal)
        {
            this.a_name = a_name;
            this.a_no = a_no;
            this.bal = bal;
        }
    }
}
