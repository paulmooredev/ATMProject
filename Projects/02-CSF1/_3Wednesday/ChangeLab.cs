using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Wednesday
{
    class ChangeLab
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Change Lab!");

            // Ask the user for money
            Console.Write("Give me money, and I'll give you change: ");
            int quarters, dimes, nickels, pennies;
            double money = double.Parse(Console.ReadLine());

            pennies = (int)(money * 100);

            //Figure out quarters
            quarters = pennies / 25;
            pennies %= 25;

            //figure out dimes
            dimes = pennies / 10;
            pennies %= 10;

            //figure out nickels
            nickels = pennies / 5;
            pennies %= 5;



            //Console.WriteLine($"{quarters} qs, {dimes} ds, {nickels} ns, {pennies} ps");


            //display the remaining amount

            //string concatenation
            Console.WriteLine(quarters + " quarters, " + dimes + " dimes, " + nickels +
                " nickels, " + pennies + " pennies.");

            //string format
            Console.WriteLine("{0} quarters, {1} dimes, {2} nickels, {3} pennies.",
                quarters,//0
                dimes,//1
                nickels,//2
                pennies);//3

            //string interpolation
            Console.WriteLine($"{quarters} quarters, {dimes} dimes, {nickels} nickels, {pennies} pennies.");
        }
    }
}
