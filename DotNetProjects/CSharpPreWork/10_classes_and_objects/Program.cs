using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_classes_and_objects
{
    class Program
    {
        static void Main(string[] args)
        {
            Donuts dougDonut = new Donuts();
            Donuts chrisDonut = new Donuts();
            Donuts nickDonut = new Donuts();

            dougDonut.Filling = "cherry";
            dougDonut.Price = 3;
            dougDonut.Type = "normal";
            dougDonut.IsSpecial = true;

            chrisDonut.Filling = "none";
            chrisDonut.Price = 2;
            chrisDonut.Type = "small";
            chrisDonut.IsSpecial = false;

            nickDonut.Filling = "chocolate";
            nickDonut.Price = 3;
            nickDonut.Type = "normal";
            nickDonut.IsSpecial = true;

            Console.WriteLine(nickDonut.Filling);
        }
    }
}
