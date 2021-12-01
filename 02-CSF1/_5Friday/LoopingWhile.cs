using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5Friday
{
    class LoopingWhile
    {
        private static bool moreBags;
        private static string bagsoFGroceries;

        static void Main(string[] args)
        {

            Console.WriteLine("Looping While");

            /*While loop - best for when you want to run code
             * an indeterminable number of times
             * (0 to ???)
             * 
             * COUNTER
             * 
             * while (CONDITION)
             * {
             *      //code to run
             *      UPDATE
             * }
             */
            int cookie = 1;//counter

            while (cookie <= 5)//condition -- no semicolons
            {
                Console.WriteLine("Yum you have eaten " + cookie);
                //update
                cookie++;//update
            }//end while

           // long number = 1;//counter

            //while (number > 0)//CONDITION
            {
                //Console.WriteLine(number);
                //umber++;//UPDATE
                //end while
                //because you can set the update conditionally,
                //it is easy to forget it... or to accidentally
                //create an infinaite loop by using a bad condition

                //virtually everytime you have an infinite loop,
                //you wrote the condition wrong.

                //Mini-lab
                //Write a while loop that starts with 10 bags of groceries
                //and counts down as they are being unloaded until they are none
                //remaining

                //counter

                //while(condition)
                //{
                //UPDATE
                //}

                int bagsOfGroceries = 10;
                while (bagsOfGroceries <= 0) ;
                Console.WriteLine("Thanks for unloading the bagsOfGroceries {0} bags left " + bagsoFGroceries);
                bagsoFGroceries--//update
                    {

                    //it is most common to use a while loop a bool
                    //for a counter as this allows us to conditionally 
                    //change the bool for when we want to exit the loop.

                    bool bagsoFGroceries = true;

                    while (bagsoFGroceries) ;
                    {
                        Console.WriteLine("\nYou have succesfully unloaded some groceries");
                        //ask the user if they have more bags
                        //if not, we are done
                        Console.Write("Do you have any more bags? Y/N: ");
                        ConsoleKey userAnswer = Console.ReadKey(true).Key;//counter


                        if (userAnswer == ConsoleKey.Y)
                        {
                            moreBags = false;//update
                        }
                    }
                    Console.Write("Would you like to play a game? Y/N ");
                    ConsoleKey runProgram = Console.ReadKey(false).Key;//Counter

                    while (runProgram == ConsoleKey.Y)
                    {
                        Console.WriteLine("\nYou win!! Y/N ");

                        Console.WriteLine("Play again? Y/N? ");
                        runProgram = Console.ReadKey(false).Key;
                    }//end while

                    //PROGRAMMER REAL WORLD EXAMPLE
                    //for Loops are great for a specific number of times to loop
                    //They are ideal when you know the COUNT

                    //While loops are great for an indeterminable number of times
                    //They are ideal when you know the CONDITION

                }

            }//end while
            c


            }
        }//end Main()
    }//end class
}//end namespace
