﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1Monday
{
    class DatesAndTimes
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DateTime Datatype");
            Console.Title = "Dates and Times. " + DateTime.Now;

            #region DateTime Notes
            /*
             * DateTime is a class from the FCL (Framework Class Library)
             * that we can use as a datatype to create variables that
             * hold date and time information.
             * 
             * Time defaults to 12am.
             * 
             * This is a complex datatype, unlike bools, ints, etc
             * which are all intrinsic/simple datatypes.
             * 
             * Complex datatypes often need the "new" keyword (just like collections)
             * and a constructor method, which has the same name as the datatype.
             * 
             * string[] colors = new string[5];
             * 
             * Syntax for DateTime:
             * DateTime x = new DateTime();
             * 
             * Format Specifiers for DateTime:
             * (d, D, M, t, T, f, F)
             */
            #endregion

            DateTime graduationDate = new DateTime(2021, 3, 3);
            Console.WriteLine("Graduation: {0:d} as a short date", graduationDate);
            Console.WriteLine("Graduation: {0:D} as a long date", graduationDate);
            Console.WriteLine("Graduation: {0:M} as a month day", graduationDate);
            Console.WriteLine("Graduation: {0:t} as a short time", graduationDate);
            Console.WriteLine("Graduation: {0:T} as a long time", graduationDate);
            Console.WriteLine("Graduation: {0:f} as a short full datetime", graduationDate);
            Console.WriteLine("Graduation: {0:F} as a long full datetime", graduationDate);
            Console.WriteLine("Graduation: {0} with no formatting", graduationDate);//short date + long time

            //MINI-LAB!
            //Create a DateTime variable for your date of birth
            //and display it with one of the format specifiers above.

            DateTime myBDay = new DateTime(1990, 06, 07);
            Console.WriteLine("My B Day: {0:D}",myBDay);

            //let's find 7 days after your bday.
            //DateTime weekAfterBDay = myBDay + 7;//Cannot add a datetime and an int

            //new DateTime(1990, 06, 30 + 7)
            //that fails only if the date passed in exceeds the value that can be stored 
            //into that property

            DateTime weekAfterBDay = myBDay.AddDays(7);
            //To explore an object with intellisense, use a period.
            //To explore a Method() with intellisense, use parens.

            Console.WriteLine($"7 days after my birthday is {weekAfterBDay:D}");

            Console.WriteLine($"3 days before my birthday is {myBDay.AddDays(-3):D}");
            //.Subtract() subracts two dates, and gives you the TimeSpan between them.
            //To subtract, we just add negative days.

            //You can determine the current date (DateTime.Today) or
            //the current Date and Time (DateTime.Now)

            //Very useful when we start recording changes
            //to information in databases.
            //Typically, we record a timestamp with any chage.

            Console.WriteLine("Current date dynamically generated {0:D}\n",DateTime.Today);
            Console.WriteLine($"Current full date and time {DateTime.Now:F}");

            DateTime myNextBday = new DateTime(2022, 06, 07);
            Console.WriteLine($"The days until your next birthday: " +
                $"{DateTime.Now.Subtract(myNextBday):dd\\ hh\\:mm\\:ss}\n");
            //NOTE: This does not show the slashes

            //How long was an employee clocked in?
            DateTime clockedIn = new DateTime(2013, 10, 17, 20, 30, 0);
            DateTime clockedOut = new DateTime(2013, 10, 18, 4, 31, 1);

            TimeSpan timeWorked = clockedOut.Subtract(clockedIn);

            Console.WriteLine($"\nOur employee was clocked in for: " +
                $"{timeWorked.Hours} hours and {timeWorked.Minutes} " +
                $"minute" +
                $"{(timeWorked.Minutes == 1 ? "" : "s")}!");//Ternary operator

            

        }
    }
}
