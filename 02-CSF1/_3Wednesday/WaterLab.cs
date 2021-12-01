using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Wednesday
{
    class WaterLab
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Water Lab!");

            //ask user for input
            Console.Write("Enter a number of gallons, and I'll tell you how much it weighs! ");
            //store it / convert it
            string nbrGallonsString = Console.ReadLine();
            decimal nbrGallons = decimal.Parse(nbrGallonsString);
            //math
            decimal weight = nbrGallons * 8.33m;
            //return the result
            Console.WriteLine($"That weighs {weight} lbs!");

            //and the short way
            //Console.WriteLine($"That weighs {decimal.Parse(Console.ReadLine()) * 8.33m} lbs!");



        }
    }
}
