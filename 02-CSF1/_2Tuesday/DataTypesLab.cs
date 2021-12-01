using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Tuesday
{
    class DataTypesLab
    {
        static void Main(string[] args)
        {
            /*string, char, bool*/
            string strAnswer = "Hello, World!";
            Console.WriteLine(strAnswer);

            char letter = 'A';
            Console.WriteLine(letter);

            bool isDone = false;
            Console.WriteLine("Done? " + isDone);

            /*floating point*/
            float fltNbr = 0.1f;
            Console.WriteLine(fltNbr);

            double dblNbr = 0.2;
            Console.WriteLine(dblNbr);

            decimal decNbr = 1093.223m;
            Console.WriteLine("DecNbr: " + decNbr);

            /*integer*/
            byte byteNbr = 109;
            Console.WriteLine("ByteNbr: " + byteNbr);

            short shortNbr = 2000;
            Console.WriteLine("ShortNbr: " + shortNbr);

            int maxInt = int.MaxValue;
            Console.WriteLine("Max Int: " + maxInt);
            int minInt = int.MinValue;
            Console.WriteLine("Min Int: " + minInt);

            long longNbr = 10983829;
            Console.WriteLine("LongNbr: " + longNbr);
        }
    }
}
