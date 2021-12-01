using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SignaturesLibrary;//added for Header()
using System.Threading;

namespace _3Wendsday
{
    class ConsoleColorPicker
    {
        static void Main(string[] args)
        {
            Signature.Header("Color and ENUMS");

            #region Exploring Console Colors & Enums
            //Enums restrict selection to a specific selection
            //List of values. They dont contain any functionallity but 
            //instead are used to set or modify functionality in the application.

            //Let's use enum to change the text color
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Text is now green");

            //ConsoleColor.SassyGrass will not work, has to be a console color
            //(ConsoleColor)4

            //Let's change the background color.
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Yay, the background is magenta");

            Console.ResetColor();
            #endregion

            Console.WriteLine("Pick your text color: Green, Blue, Red, Cyan");
            

            ConsoleColor iLikeTurtles = ConsoleColor.Green;

            string textColor = null;
            switch (textColor)
            {
                case "G":
                case "GREEN":
                    Console.ForegroundColor = iLikeTurtles;
                    break;

                case "B":
                case "BLUE":
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;

                case "R":
                case "RED":
                    break;

                case "C":
                case "Cyan":
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    break;

                default:
                    Console.WriteLine("Input not recognized. Resetting color...");
                    Console.ResetColor();
                    break;
            }//end of switch
            Console.WriteLine("Here is your text now!");

            //MINI-LAB
            Console.WriteLine("Pick your background color: " +                "Yellow, Gray, or Black");            string backColor = Console.ReadLine().ToUpper();            switch (backColor)            {                case "Y":                case "YELLOW":                    Console.BackgroundColor = ConsoleColor.DarkYellow;                    break;                case "G":                case "GREY":                case "GRAY":                    Console.BackgroundColor = ConsoleColor.DarkGray;                    break;                case "B":                case "BLACK":                    Console.BackgroundColor = ConsoleColor.Black;                    break;                default:                    Console.WriteLine("Input not recognized. Resetting color...");                    Console.ResetColor();                    break;            }//end switch


            Console.WriteLine("Here is your background color");

            //This change only affects output written to individual character cells.
            //To change the color of the entire consoles background, FIRST, set the color.
            //THEN call the clear()
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();

            Console.WriteLine("And now, a new console background!");

            //Beep is a static method called from the Console class.
            //It accepts 2 arguments, and int for the frequeny, and a int for the duration
            //in miliseconds. (thousndths of a sec.)

            Console.WriteLine("Thats it Enjoy!");
            Console.Beep(660, 125);
            Thread.Sleep(167);
            Console.Beep(523, 125);
            Console.Beep(659, 125);
            Thread.Sleep(125);
            Console.Beep(784, 125);
            Thread.Sleep(350);
            Console.Beep(392, 125);
            Thread.Sleep(350);
            Console.Beep(523, 125);
            Thread.Sleep(200);
            Console.Beep(392, 125);
            Thread.Sleep(200);
            Console.Beep(330, 125);
            Thread.Sleep(200);
            Console.Beep(440, 125);
            Thread.Sleep(100);
            Console.Beep(494, 125);
            Thread.Sleep(100);
            Console.Beep(466, 125);
            Thread.Sleep(42);
            Console.Beep(440, 125);
            Thread.Sleep(125);
            Console.Beep(392, 125);
            Thread.Sleep(100);
            Console.Beep(659, 125);
            Thread.Sleep(100);
            Console.Beep(784, 125);
            Thread.Sleep(100);
            Console.Beep(880, 125);
            Thread.Sleep(100);
            Console.Beep(698, 125);
            Console.Beep(784, 125);
            Thread.Sleep(100);
            Console.Beep(659, 125);
            Thread.Sleep(100);
            Console.Beep(523, 125);
            Thread.Sleep(100);
            Console.Beep(587, 125);
            Console.Beep(494, 125);
            Thread.Sleep(100);
            Console.Beep(523, 125);
            Thread.Sleep(250);
            Console.Beep(392, 125);
            Thread.Sleep(250);
            Console.Beep(330, 125);
            Thread.Sleep(250);
            Console.Beep(440, 125);
            Thread.Sleep(125);
            Console.Beep(494, 125);
            Thread.Sleep(125);
            Console.Beep(466, 125);
            Thread.Sleep(42);
            Console.Beep(440, 125);
            Thread.Sleep(125);
            Console.Beep(392, 125);
            Thread.Sleep(125);
            Console.Beep(659, 125);
            Thread.Sleep(125);
            Console.Beep(784, 125);
            Thread.Sleep(125);
            Console.Beep(880, 125);
            Thread.Sleep(125);
            Console.Beep(698, 125);
            Console.Beep(784, 125);
            Thread.Sleep(125);
            Console.Beep(659, 125);
            Thread.Sleep(125);
            Console.Beep(523, 125);
            Thread.Sleep(125);
            Console.Beep(587, 125);
            Console.Beep(494, 125);
            Thread.Sleep(375);
            Console.Beep(784, 125);
            Console.Beep(740, 125);
            Console.Beep(698, 125);
            Thread.Sleep(42);
            Console.Beep(622, 125);
            Thread.Sleep(125);
            Console.Beep(659, 125);
            Thread.Sleep(167);
            Console.Beep(415, 125);
            Console.Beep(440, 125);
            Console.Beep(523, 125);
            Thread.Sleep(125);
            Console.Beep(440, 125);
            Console.Beep(523, 125);
            Console.Beep(587, 125);
            Thread.Sleep(250);
            Console.Beep(784, 125);
            Console.Beep(740, 125);
            Console.Beep(698, 125);
            Thread.Sleep(42);
            Console.Beep(622, 125);
            Thread.Sleep(125);
            Console.Beep(650, 125);
            Thread.Sleep(167);
            Console.Beep(1050, 125);
            Thread.Sleep(125);
            Console.Beep(1050, 125);
            Console.Beep(1050, 125);
            Thread.Sleep(625);
            Console.Beep(784, 125);
            Console.Beep(740, 125);
            Console.Beep(698, 125);
            Thread.Sleep(42);
            Console.Beep(622, 125);
            Thread.Sleep(125);
            Console.Beep(659, 125);
            Thread.Sleep(167);
            Console.Beep(415, 125);
            Console.Beep(440, 125);
            Console.Beep(523, 125);
            Thread.Sleep(125);
            Console.Beep(440, 125);
            Console.Beep(523, 125);
            Console.Beep(587, 125);
            Thread.Sleep(250);
            Console.Beep(622, 125);
            Thread.Sleep(250);
            Console.Beep(587, 125);
            Thread.Sleep(250);
            Console.Beep(523, 125);

            /*
             * You can use the Sleep() to pause the execution of the next line
             * of code for a specified number of milliseconds. The Sleep() is part of 
             * the "ThREAD" class in the system namespace. We Don't 
             * have the thread class available to us from the FCL by default, so 
             * we have to add a using statement for system. Threading to access it.
             * (Using sysem.Threading;)
             */

            Thread.Sleep(500);
            Console.Beep(100, 1000);

             
        }
    }
}
