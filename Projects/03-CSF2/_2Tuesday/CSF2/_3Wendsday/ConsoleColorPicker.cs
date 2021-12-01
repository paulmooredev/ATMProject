using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SignaturesLibrary;//added for Header()

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
        }
    }
}
