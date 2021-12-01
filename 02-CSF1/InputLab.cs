using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Thursday
{
    class InputLab
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input Lab!");

            /*
             * Ask the user for the following info:
             *     - Favorite season
             *     - Favorite car
             *     - Favorite TV show
             *     - How much they spent on cable last year
             *      
             * Give them a response using all of their info
             * in one statement at the end using string formatting or 
             * interpolation. Use currency formatting when you display 
             * the cable bill.
             */

            Console.WriteLine("What is your favorite season?");
            string inputSeason = Console.ReadLine();

            Console.WriteLine("What is your favorite car?");
            string inputCar = Console.ReadLine();

            Console.WriteLine("What is your favorite TV show?");
            string inputTV = Console.ReadLine();

            Console.Write("How much did you spend on cable " +
                "last year?: $");
            //string cableString = Console.ReadLine();
            //decimal inputCable = decimal.Parse(cableString);
            decimal inputCable = decimal.Parse(Console.ReadLine());

            Console.WriteLine("The {0} is a beautiful car, but not "
                + "very practical in the {1}. I know, because I "
                + "watch a lot of {2}. {3:c} Seems like a lot for cable.",
                inputCar, inputSeason, inputTV, inputCable);

        }//end Main()
    }//end class
}//end namespace
