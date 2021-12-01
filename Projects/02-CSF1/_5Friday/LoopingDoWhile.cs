using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5Friday
{
    class LoopingDoWhile
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Do While Loop");
            Console.Title = "Looping With Do While";

            /* Do While Loop - best for when you want to run code
             * an indeterminable number of times BUT
             * at least once!!!
             * (1 to ???)
             * 
             * COUNTER
             * 
             * do
             * {
             *      //code to run
             *      UPDATE
             *      
             * } while (CONDITION);
             */
            int cookie = 1;//counter

            do
            {
                Console.WriteLine("Yum! You have had " + cookie);
                cookie++;//update
            } while (cookie <= 5);//Condition, dont forge the semicolon

            //A bad do while: 
            Console.WriteLine("\nDo you want to run this program?");
            string runProgram = Console.ReadLine().ToUpper();

            do
            {

            } while (runProgram == "Y || runProgram == "YES);

            //Real world example
            bool repeat = true;
            //generally, you write a while or a do while to run forever,
            //and you just deal with the user when they want to stop.
            //the above bool is our counter.

            do
            {
                //because they only run once, they are best used for menus!
                Console.WriteLine("-= Wekk Ant Eeru Phone Company =-");
                Console.WriteLine(@"
B) Bill
P) Payment
S) Service
X) Exit
");
                string userChoice = Console.ReadLine().ToLower();
                
                //clear console after output
                Console.Clear();

                switch (userChoice)
                {
                    default:
                        Console.WriteLine("That was not a valid option.\n" +
                            "A $5 invalid option fee has been applied to your bill.");
                        break;

                        //update 
                        repeat = false;
                        break;

                    default:
                        Console.WriteLine("That was not a valid option.\n" +
                            "As $5 invalid option fee has been applied to your bill.");


                }
            } while (repeat);//condition



        }//end Main()
    }//end class
}//end namspace
