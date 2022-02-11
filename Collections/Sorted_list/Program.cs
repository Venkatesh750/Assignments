using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Sorted_List
{
    class Program
    {
        static void Main(string[] args)
        {
            // The SortedList class represents a collection of key and value pairs

            // calling the method
            s_list();
        }

        public static void s_list()
        { 
            // creating a sortedlist
            SortedList slst = new SortedList();

            slst.Add("01", "Mon");
            slst.Add("02", "Tue");
            slst.Add("03", "Wed");
            slst.Add("04", "Thu");
            slst.Add("05", "Fri");
            slst.Add("06", "Sat");
            slst.Add("07", "Sun");

            // printing the values using foreach
            foreach(DictionaryEntry val in slst)
            {
                Console.WriteLine(val.Key+" "+val.Value);
            }
        }
    }
}
