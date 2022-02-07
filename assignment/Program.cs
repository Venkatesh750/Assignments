using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {

            /*  Create a C# program that prompts the user for three names of people and stores them in an array of Person-type objects.
                
            To do this, first create a Person class that has a Name property of type string, a constructor that receives the name as a
            
            parameter, a destructor that assigns the name to empty and overwrites the ToString () method.  */


            int total = 3;
            Person[] persons = new Person[total];

            Console.WriteLine("Enter the names of 3 people :");

            for (int i = 0; i < total; i++)
            {
                persons[i] = new Person(Console.ReadLine());
            }

            for (int i = 0; i < total; i++)
            {
                Console.WriteLine(persons[i].ToString());
            }
        }   
    }
}
