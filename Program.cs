using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefsAndOuts
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create an integer to store the value of a number
            int x;
            Console.WriteLine("Enter a number:");
            x = Convert.ToInt32(Console.ReadLine());
            //Show what happens to the number after regular function
            RegularFunction(x);
            Console.WriteLine("Regular Function: " + x);

            //Show what happens to the number after passing by reference
            ByReferenceFunction(ref x);
            Console.WriteLine("Reference Function: " + x);

            //Show what happens when passing with out
            ByOutFunction(out x);
            Console.WriteLine("Out function:" + x);
            Console.ReadLine();
        }

        static void RegularFunction(int number)
        {
            //The value is local to the function
            number += 10;
        }

        static void ByReferenceFunction(ref int number)
        {
            //The value of number is passed by reference
            number += 10;
        }
        static void ByOutFunction(out int number)
        {
            //The value of number is discarded upon entry
            number = 0;
            number += 10;
        }
    }
}
