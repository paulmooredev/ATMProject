using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Thursday
{
    class BranchingSwitches
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Branching Switch Statements");

            /*
             * Switches are the other form of branching.
             * Not as flexible as IF (don't handle ranges well)
             * But GREAT at exact matching.
             * 
             * SYNTAX:
             * 
             * switch (valueToCheck)
             * {
             *      case TEST:
             *          //code
             *          break;
             *          
             *      default:
             *          //code
             *          break;
             * }
             *
             *if (valueCheck) == InvalidCastException TEST)
             * else ifs = multipule cases
             *else = default
            */
            Console.WriteLine("Enter a number: ");
            short userNumber = short.Parse(Console.ReadLine());

            switch (userNumber)
            {
                case 1:
                    //code...
                    Console.WriteLine("You typed 1");
                    break;
                case 2:
                    break;
                case 3:
                        break;
                default:
                Console.WriteLine("You typed 2-5 or 42");
                    //This treats multipule cases like ||
                    break;
                    //Optional has no test, it is like a ||
                    Console.WriteLine("You picked something else");

                    //IF YOU SEE THE ERROR CANNOT FALL OUT
                    //You missed a break; (Break the fall)

                    //NOTE: Although we did "ranges" abouve, this should
                    //indicate that ranges do not work well with others.

                    //switches are commonly used for menus
                    Console.WriteLine(@"
Please choose a program to run
1)Numbers
2)Drawing
3)Water
4)Change
");
                    string userOption = Console.ReadLine().ToUpper();

                    switch (userOption)
                    {
                        case "1":
                        case "Numbers":
                        case "N":
                            Console.WriteLine("1, 2, 3, 4, 5, 6, 7, ah, ah, ah");
                            break;

                        case "2":
                        case "DRAWING":
                        case "D":

                            //code to run, could be hundreds of lines of code
                            Console.WriteLine(@"Lookie! I made a sword!

                            0===={:::::::::::::::::::::::::::::::>

                            ");
                            break;//break the fall

                        case "3":
                        case "WATER":
                        case "W":
                            Console.Clear();
                            Console.WriteLine("WATER LAB");
                            //You can copy and paste all of your code from inside of the SVM method for your water 
                            //into this spot
                            break;

                        case "4":
                        case "CHANGE":
                        case "C":
                        break;

                        default:
                            Console.Clear();
                            Console.WriteLine("Input unrecognized. Please restart the program and try again");
                            break;
                    }
            //end switch
        }// end Main()
    }//snd class
}//end namespace
