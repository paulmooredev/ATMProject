using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Thursday
{
    class Arrays
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Arrays! Yay");

            /*
             * An array stores a fixed-size sequential collection of 
             * objects of the same type. 
             * 
             * An array is used to store a collection of 
             * data, but it is often more useful to think of an array as 
             * a collection of variables of the same type.
             * 
             * Standard Arrays: 
             * 
             * - Have a fixed size (can't change it programmatically)
             * - The size is called the Length (1-based counting)
             * - Uses 0-based counting for the positions of the indexes.
             * - Type safe
             * - Use the "new" keyword to call the "constructor" that builds the object
             */

            //One way to create a array:
            //declare with set Length (1-based counting)
            string[] dresser = new string[4];
            //string array call dresser and assigned it Length of 4.

            //Now initialize the values individually.
            //You must initialize them before you can use them.
            //You can initialize them in any order.
            dresser[0] = "shirts";//in the drawer with an index of 0, put "shirts"
            dresser[1] = "pants";
            dresser[3] = "socks";
            dresser[2] = "shorts";

            //each of the indexs called by dresser[indexNumber]
            //is a variable that you can use in your program.

            Console.WriteLine($"{dresser[2]} are in the drawer with an index of 2");

            //MINI-LAB
            //Write out the last index to the screen using string interpolation.
        }
        //Another array, created the long way.
        //The long way is best if you don't know what all
        //you want to put in the boxes.
        //You must still know exactly how many boxes you need!

        decimal[] prices = new decimal[5];

        //The second way to declare an array
        //declare and initialize a array.
        //you must know all of the values that yo u
        //want to put into the boxes first. 

        //this is called collection initialization syntax

        string[] toolBox = { "wrenches",     //0
                             "screwdriver",  //1
                             "sockets",      //2
                             "hammers" };    //3

        //.net will determine the Length based apon the number of items
        //being initalized and will put them intothe indexes in the order provided.

        int number = 42;

        bool[] boolpen = { true, false, true };

        public Arrays(decimal[] prices, string[] toolBox, int number, bool[] boolpen)
        {
            this.prices = prices;
            this.toolBox = toolBox;
            this.number = number;
            this.boolpen = boolpen;

            //arrays they are apart of the collections family
            //we will get more into next week
            //A string is a collection of chars!
            //As a collection it will have length and it will have indexes just like
            //an array. This gives us eome useful functionality.

            //The substring method!
            string stringName = "Ben Kenobi";
            int location = stringName.IndexOf(" ");
            //the indexof() instance method gives us the index location
            //of a char in the string (3 in this case)
            //we could have just as easily picked the indexOf("K") or "o"
            //if there are more than one identical chars
            //it will return the very first one in the string from left to right
            string firstName = stringName.Substring(4, location);

            //we take the starting index and than tell
            //it how many character to capture after that point.
            //we use indexes 0 to 2 in this case, but 
            //0 to 3 would have given us the same restul only because, the value in
            //index 3 is a blank space. (location + 1);

            Console.WriteLine(firstName);
            string lastName = stringName.Substring(location + 1);
            Console.WriteLine(lastName);
        }//Generally, collections have a pluralized name.
        //to explore an object in intellisense, usa a period
        //The first index is always 0.
    }
}