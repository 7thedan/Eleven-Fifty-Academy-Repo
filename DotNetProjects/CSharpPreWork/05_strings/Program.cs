using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_strings
{
    class Program
    {
        static void Main(string[] args)
        {

            //Concatenation
            string first = "The cars we sell are ";
            string second = "BMW, Lexus, and Mercedes.";
            Console.WriteLine(first + second);

            //result: The cars we sell are BMW, Lexus, and Mercedes.

            //Composite Formatting:
            string firstSales = "The cars we sell are ";
            string secondSales = "BMW, Lexus, and Mercedes.";
            Console.WriteLine(firstSales + secondSales);

            //result: The cars we sell are BMW, Lexus, and Mercedes.

            //String Interpolation:
            string firstName = "Robin";
            string lastName = "Holler";
            //1                 //2
            Console.WriteLine($"Her name is {firstName} {lastName}");
        }
    }
}
