using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string txt = "Dungeon of Doom!";
            Console.Title = txt;

            //example of centering text in the console window
            Console.WriteLine("{0," +
                ((Console.WindowWidth / 2) + txt.Length / 2) + "}", txt);

            Console.WriteLine("Dare all who enter\n");

            int score = 0;
        }
    }
}

           