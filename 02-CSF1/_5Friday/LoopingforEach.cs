using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5Friday
{
    class LoopingforEach
    {
        private static object totalSale;

        static void Main(string[] args)
        {
            Console.WriteLine("Looping ForEach");
            Console.Title = "LOOPING WITH FOREACH";


            string[] color = { "red, blue, purple, green, orange, yellow, black, gray" };


            foreach (string color in colors)
            {
                Console.WriteLine(color);
                //color[1] = "red";// cant do this in a foreach
                //READONLY You can not change the values in a forach

                int[] gradeScore = { 100, 80, 34, 25, 10 };

                foreach (int score in gradeScores) ;
                {
                    Console.WriteLine(bob);
                }// end foreach

                decimal[] cartPrices = { 12.99m, 2, 9.99m, 10, 20 };

                //mini-lab
                //print out each price with a foreach structure using currency formatting


                Console.WriteLine("Looping ForEach");
                Console.Title = "LOOPING WITH FOREACH";

                int[] GasPrices = { 15.5m, 12.5m, 22.1m, 400.5m, 3372.0m };
                string[] price = { "15.5m, 12.5m, 22.1m, 400.5m, 3372.0m, 223.8m" };
                foreach (decimal prices in GasPrices) ;
                decimal[] prices = { 12.99m, 2, 9.99m, 10, 20 };
                Console.WriteLine("Looping ForEach");
                Console.Title = "LOOPING WITH FOREACH";
            }//end foreach

            //lets total up all of the prices in the cart.
            //create running total variable so we can
            //print out the total AFTER the foreach

            foreach (decimal item in collection)
            {
                totalSale = totalSale + price;
                //totalSale += price;
                //either of the above work but only use one
                Console.WriteLine($"After adding {price:c}, the total is now: {totalSale:c}");//{cartPrices.Sum():c}                        



            }//end Main()
        }//end class
}//end namespace
