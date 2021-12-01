using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Tuesday
{
    class CastingLab
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Casting Lab!");

            //some variables to use:
            byte puddle = 100;
            short pond = 29456;
            int lake = 100000; //one hundred thousand
            long ocean = 5;

            //1. cast the value of lake into ocean and display it
            //2. cast the value of pond into puddle and display it
            //3. cast the value of pond into ocean and display it
            //4. cast the value of ocean into lake and display it

            //for each casting, include a comment categorizing it as:
            //implicit casting
            //explicit casting
            //explicit casting with truncation

            //REMEMBER.... right to left thinking....

            //1. lake into ocean
            ocean = lake;//implicit
            Console.WriteLine("Ocean is now " + ocean); 

            //2. pond into puddle 
            puddle = (byte)pond;//explicit casting with truncation
            Console.WriteLine("Puddle is now " + puddle);

            //3. pond into ocean
            ocean = pond;//implicit
            Console.WriteLine("Ocean is now " + ocean);

            //4. ocean into lake
            lake = (int)ocean;//explicit casting
            Console.WriteLine("Lake is now " + lake);

            //! Bonus example:
            //puddle into ocean
            //ocean = (long)puddle;
            //it works, but isn't nessecary
            //.Net KNOWS there won't be a problem and just tacks on 
            //the extra 0's
            //Above we are doing it FOR .Net (think of this as
            //over explaining)

            //! Solution:
            // 100000
            // 16
            // 29456
            // 29456


        }//end main
    }//end class
}//end namespace
