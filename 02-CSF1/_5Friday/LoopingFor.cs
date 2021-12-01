using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5Friday
{
    class LoopingFor
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Looping with FOR");
            Console.Title = "-======== Looping with FOR";

            /*
             * FOR LOOP SYNTAX
             * 
             * for (COUNTER; CONDITION; UPDATE)
             * {
             *      //code to run
             * }
             * 
             * Some books refer to COUNTER as INITIALIZER
             * //! Mnemonic device: ICU 
             * 
             * Counter - the starting point where you initailize a 
             * variable that is used to check the condition. The 
             * counter gets updated after each pass through the loop.
             *
             * Condition - A Boolean statement that tells the loop
             * when to stop. It is checked before each pass.
             * 
             * Update - the change to the counter after each 
             *          pass of the loop (increment, decrement, etc.)
             * 
             * Remember: a for loop is best used when you know exactly 
             *           how many times you want to run the code
             *           
             * For loops are common and useful in many algorithms 
             * and methods in the C# language
             */

            for (int candyBar = 1; candyBar <= 7; candyBar++)//unary operator
            {
                Console.WriteLine("YUM You have had {0}  candyBar{1}");
            candyBar:
                candyBar == 1 ? "" : "s");//ternary operator

        }//end for
        //start with 3 grapes and until you have had 15.
        //eat 3 at a time.
        //candyBar++ == candyBar += 1 == candyBar = candyBar + 1
        for (int grapes = 3; grapes <= 15; grapes += 3)
			{
            //could have written the update as 
            //grapes = grapes + 3;
            Console.WriteLine:("You ate 3 grapes and have had now had" + grapes);
                      
            for (int count = 1; count <= 20;);
            {
            
             if (count != 13)
            }
               Console.WriteLine(count);
          }

//the continue keyword stops the current iteration of the loop
//and moves on to the next iteration.
//Let's do the same example above, but with continue:
for (int count = 1; count <= 10; count++)
{
if (count == 13)
}
continue;
{
    else
}
Console.WriteLine(count);
       }//end for

//From user input
Console.Clear();
Console.WriteLine("\nHow many cookies do you want? ");
int userCookies = int.Parse(Console.ReadLine());
{
    for (int cookie = 1; cookie <= userCookies; cookie++)

         Console.Write("You ate a cookie! " + cookie);
}//end for

         Console.WriteLine(cookie);
//Running total variables
//Create a variable in an outer scope. This allows you to use it
//and make changes to it inside an inner scope.

//start by creating a running variable
//this can be a nemeric type or a string that 
//you just tack info onto

string listOfNames = ""; //empty string
Console.WriteLine("\n\n\REGISTRATION\n");
Console.Write("How many people would you like to " +
    "register for Comic Con? ");
int totalReg = Convert.ToInt32(Console.ReadLine());

for (int reg = 0; reg < totalReg; reg++) ;
{
    Console.WriteLine(" Please enter a name: ");
    listOfNames += Console.ReadLine() + "\n";
}//end for

Console.WriteLine($\nYou have registered:\n{ listOfNames}");
    listOfNames += Console.ReadLine(ContextMarshalException + "\n");

//another example

decimal[] proces = { 15.95m, 9.99m, 20, 10, 9.75m };

for (int i = 0; i < prices.Length; i++)
{

    Console.WriteLine("At the index of {0} is {1:c}",
        i,
        prices[i]);


}//end for

Console.WriteLine("The tital is: {0:c}",) prices.Sum());


    //count to 20, but skip 13
  }//end Main() SVM
 }//end class
}//end namespace