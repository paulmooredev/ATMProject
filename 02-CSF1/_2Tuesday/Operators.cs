﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Tuesday
{
    class Operators
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mathematical Operators");
            Console.WriteLine();

            //concatenation review
            Console.WriteLine(3 + 5);//adding two literal numbers
            Console.WriteLine(3 + "5");//35 because 5 is a string

            //other basic operators

            Console.WriteLine(12 - 8);//subtraction

            Console.WriteLine(10 / 5);//division

            Console.WriteLine(2 * 11);//multiplication

            int legos = 15 + 27;
            Console.WriteLine(legos);

            //We can make a lego car from 9 pieces. How many
            //Lego cars can we make? 
            int legoCars = legos / 9;
            Console.WriteLine("We can make " + legoCars + " cars.");

            //what if we wanted the fraction answer? 
            int piecesLeftOver = legos % 9;//42 - (9 * 4))
            Console.WriteLine(piecesLeftOver + " pieces remaining");

            Console.WriteLine();
            //we have 75 nails. It takes 30 nails to make a dresser.
            //How many dressers can we make, and how many nails would
            //remain?
            int nails = 75;

            int dressersMade = nails / 30;
            int nailsLeftOver = nails % 30;
            //for both variables, we asked the same question,
            //but requested different parts of the answer. 
            Console.WriteLine("We made " + dressersMade +
                " dressers and have " + nailsLeftOver +
                " nails remaining");

            Console.WriteLine();

            //MINI-LAB!
            //There are 100 cookies and 47 students.
            //How many cookies does each student get, and how
            //many are left over?
            int cookies = 100,
                students = 47,
                cookiesPerStudent = cookies / students,
                cookiesLeftOver = cookies % students;

            Console.WriteLine("The students get " + cookiesPerStudent +
                " each and there are " + cookiesLeftOver +
                " cookies left over");

            Console.WriteLine();
            //Unary operators are used to quickly
            //increment or decrement a variables value.

            int hobbits = 2;
            Console.WriteLine("We have " + hobbits + " hobbits");

            //to add one the long way we would have to write like:
            hobbits = hobbits + 1;
            Console.WriteLine("Hobbits is now " + hobbits);
            //short cut (unary operator)
            hobbits++;
            Console.WriteLine("Hobbits is now " + hobbits);

            //to subtract one the long way we would have to write like:
            hobbits = hobbits - 1;
            Console.WriteLine("Hobbits is now " + hobbits);
            //short cut (unary operator)
            hobbits--;
            Console.WriteLine("Hobbits is now " + hobbits);

            Console.WriteLine();

            /*
             * Above, we put the unary operator AFTER the variable name,
             * however, it can also come before the variable, which affects
             * how the incrementation occurs.
             * variable++ is a POST-FIX (happens LAST)
             * ++variable is a PRE-FIX (happens FIRST)
             */

            int goblins = 12,
                orcs = 1,
                badGuys = goblins + orcs++;

            Console.WriteLine("badGuys was assigned BEFORE orcs was incremented: " + badGuys);
            Console.WriteLine("orcs incremented AFTER badGuys was assigned: " + orcs);
            Console.WriteLine();

            int xboxGames = 12,
                psGames = 1,
                games = xboxGames + ++psGames;
            Console.WriteLine("games was assigned AFTER psGames was incremented: " + games);
            Console.WriteLine("psGames was incremented BEFORE games was assigned: " + psGames);

            //Could have been written as
            //psGames = psGames + 1;
            //games = xboxGames + psGames;

            Console.WriteLine();

            //Assignment Operators
            // = assigns the value on the right to the variable on the left.
            //It can also be used with mathematical operators to create a 
            //shortcut to do math on a variable and reassign the new value back
            //to that variable.
            // +=, -=, *=, /=, %=

            int players = 2;
            Console.WriteLine(players);

            //long way to add 4 to players
            players = players + 4;//6
            Console.WriteLine(players);

            //shortcut (assignment operator)
            players += 4;//10
            Console.WriteLine(players);

            //Multiply the long way
            players = players * 3;//30
            Console.WriteLine(players);

            //Assignment operator multiply by 3
            players *= 3;//90
            Console.WriteLine(players);

            //MINI-LAB -- continue using the player variable
            //Divide by 3 both the long way, and the short way. Print the answer each time.
            Console.WriteLine(players = players / 3);//30
            Console.WriteLine(players /= 3);//10

            //Subtract by 8 both the long way, and the short way. Print the answer each time.
            Console.WriteLine(players = players - 8);//2
            Console.WriteLine(players -= 8); //-6

            //Finally, modulus by 2 using the shortcut only and print the final result.
            Console.WriteLine(players %= 2);
            //Modulus by 2 will tell you if a number is even or not.
            //If there is a remainder (1), then the number is odd.
            Console.Clear();

            Console.WriteLine(67 % 2);//odd
            Console.WriteLine(888 % 2);//even

            Console.WriteLine();
            //Standard mathematical ORDER OF OPERATIONS sequence (P-E-MD-AS)
            //applies with all operators in a mathematical expression.
            int newCalculation = 5 + 3 * 6 / 2 + 12;//26
            Console.WriteLine(newCalculation + " without parens.");

            int newCalculation2 = (5 + 3) * 6 / 2 + 12;//36
            Console.WriteLine(newCalculation2 + " WITH parens");

        }// end SVM
    }// end class
}// end namespace
