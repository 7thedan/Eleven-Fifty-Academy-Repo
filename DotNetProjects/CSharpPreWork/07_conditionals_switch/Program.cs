using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_conditionals_switch
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            
           Console.WriteLine("Enter an letter to see if it's a vowel");
            string userIntput = Console.ReadLine().ToUpper();

            //2
            switch (userIntput)
            {
                case "A":
                    Console.WriteLine("A is a vowel");
                    break;
                case "E":
                    Console.WriteLine("E is a vowel");
                    break;
                case "I":
                    Console.WriteLine("I is a vowel");
                    break;
                case "O":
                    Console.WriteLine("O is a vowel");
                    break;
                case "U":
                    Console.WriteLine("U is a vowel");
                    break;
                default:
                    Console.WriteLine($"{userIntput} is not a vowel");
                    break;
            };
            //5


        }
    }
}
