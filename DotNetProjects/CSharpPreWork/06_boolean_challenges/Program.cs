using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_boolean_challenges
{
    class Program
    {
        static void Main(string[] args)
        {

            int myValue = 14;
            Console.WriteLine("guess a number 1 to 20");
            int.TryParse(Console.ReadLine(), out int userEnter);

  
            
                if (userEnter <= 14)
                {
                    Console.WriteLine("Choose a bigger number");
                }

                else if (userEnter >= 14)
                {
                    Console.WriteLine("Chose a lower number");
                }
            Console.ReadLine();

        
 
        }
    }
}
