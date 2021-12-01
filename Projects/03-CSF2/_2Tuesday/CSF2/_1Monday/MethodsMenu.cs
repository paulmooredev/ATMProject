using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//adding a using statement to make the signatures library
//easier to use
using SignaturesLibrary; //added

namespace _1Monday
{
    class MethodsMenu
    {
        static void Main(string[] args)
        {

            Signature.Header("Methods Menu");
            //The Signature class and Header() exist in the SignaturesLibrary
            //namespace. To get access to them, we have to point _1Monday to the
            //SignaturesLibrary namespace by adding a reference.

            //Console.WriteLine("Methods Menu - Creating our own methods!");
            //Console.Title = "Methods Menu";

            #region Methods Notes
            /*
             * This program lets the user choose between various
             * "mini programs" to run. It is set up inside a loop
             * to repeat based on user choice
             * 
             * All choices will call on a method where the real 
             * functionality is located
             * 
             * Developers put functionality into methods to be more 
             * reusable, or sometimes just to "tidy up" their code.
             * 
             * Note: Static methods defined inside of this class will be able
             * to be called directly without using the classname.
             * Methods OUTSIDE the class but still INSIDE the project will
             * be called from ClassName.MethodName.
             */

            #endregion

            bool exit = false; //COUNTER

            do
            {
                //print menu
                Console.WriteLine(@"
Please choose a program
B) Break Change
W) Water Weight
N) Numbers
T) Display Time
C) Calendar App
X) Exit");
                string choice = Console.ReadKey(true).Key.ToString();
                Console.Clear();//BEST USED AFTER ReadLine/Key(). If you 
                                //do it before, they will never see the menu.

                switch (choice)
                {
                    case "B":
                        Console.WriteLine("Break Change");
                        BreakChange();
                        break;

                    case "W":
                        Console.WriteLine("Water Weight");
                        WaterWeight();
                        break;

                    case "N":
                        Console.WriteLine("Numbers");
                        CountNumbers();
                        break;

                    case "T":
                        Console.WriteLine("Display Time");
                        DateTimeWarehouse.DisplayTime();
                        break;

                    case "C":
                        Console.WriteLine("Calendar App");
                        Console.WriteLine("Please enter a number of days from today to display.");
                        //string futureDays = Console.ReadLine();
                        //int userDays = Convert.ToInt32(futureDays);
                        //DateTime newDate = DateTimeWarehouse.CalculateDate(userDays);
                        //DateTimeWarehouse.DisplayTime(newDate);

                        //REFACTOR:
                        DateTimeWarehouse.DisplayTime(DateTimeWarehouse.CalculateDate(Convert.ToInt32(Console.ReadLine())));

                        break;

                    case "X":
                    case "E":
                    case "Escape":
                        Console.WriteLine("Thank you for using the program");
                        exit = true; //UPDATE
                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Input not recognized. Please try again.");
                        Console.ResetColor();
                        break;
                }

            } while (!exit);//since the condition needs a TRUE statement,
            //the ! merely states that it should look for a NOT TRUE (false) 
            //Could have written like: 
            //while (exit == false);
            //while (exit != true);
            //the above is our CONDITION

        }//end main()

        private static void CountNumbers()
        {
            //Private: Only usable within this file
            //static: called from the classname in other files.
            //void: Doing all of the work right here
            //No params because we don't need any outside information

            Console.WriteLine("Enter a whole number to count to: ");
            int userNumber = int.Parse(Console.ReadLine());

            for (int i = 1; i <= userNumber; i++)
            {
                Console.WriteLine(i);
            }

        }//end CountNumbers()

        private static void WaterWeight()
        {
            //Cut and paste all of the code from inside the main method
            //of your WaterLab from CSF1 into this method
            Console.WriteLine("Water Lab");

            decimal galWaterInLbs = 8.33m;
            Console.Write("How many gallons of water? ");
            string userGal = Console.ReadLine();
            decimal userGalNbr = Convert.ToDecimal(userGal);
            userGalNbr *= galWaterInLbs;
            Console.WriteLine("That weighs {0} pounds!",
                userGalNbr);
        }//end WaterWeight()

        private static void BreakChange()
        {
            //You can copy your change lab code here
            //DO NOT INCLUDE THE SVM, just what's inside it
            Console.Write("Please enter an amount of dollars and cents:");
            decimal userDecimal =
                decimal.Parse(Console.ReadLine()) * 100;
            int user = (int)userDecimal;
            int quarters = 0;
            quarters = user / 25;
            user %= 25;
            int dimes = 0;
            dimes = user / 10;
            user %= 10;
            int nickels = 0;
            nickels = user / 5;
            user %= 5;
            int pennies = user;
            Console.WriteLine("\nYou have:\n{0} Quarters\n{1} Dimes\n{2} Nickels" +
                "\n{3} Pennies", quarters, dimes, nickels, pennies);
        }//end BreakChange()
    }//end Class
}//end namespace

