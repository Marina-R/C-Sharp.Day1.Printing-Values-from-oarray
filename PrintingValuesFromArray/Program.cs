using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintingValuesFromArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] myArray = new string[5];
            Console.WriteLine("Enter 5 integers");
            for(var i = 0; i<5; i++)
            {
                var input = Console.ReadLine();
                myArray[i] = input;
            }
            foreach(string i in myArray)
            {
                Console.WriteLine(i);
            }
            

        }
    }
}
