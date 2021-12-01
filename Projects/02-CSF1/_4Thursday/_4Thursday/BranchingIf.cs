using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Thursday
{
    class BranchingIf
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Branching with if");

            /*
             * If allows you to test for a condition. If that
             * condition is true it runs the code inside of the scope.
             * Otherwise, the scope is skipped.
             * 
             * Optionally, you can add one or more else ifs that will
             * run if the previous conditions were not met and their
             * condition is true.
             * 
             * Optionally, you can also include 1 final ELSE with NO
             * condition, it will always run if nothing else above
             * did, and it MUST always be the last statement of
             * an IF tree.
             */

            Console.WriteLine("What day is it? Monday, Tuesday, etc...");
            string userDay = Console.ReadLine().ToLower();

            if (userDay == "thursday")
            { //The code here in this scope will only run if the above condition is true.
                Console.WriteLine("I never could get the hang of Thursdays...");
            }//end if

            Console.WriteLine("Moving Along");

            //Now a FULL if tree
            //Only 1 scope of an IF tree will run.
            int monsterStrength = 100;
            int heroStrength;
            Console.WriteLine("In this cave, you see bones and a white rabbit.");
            Console.WriteLine("Enter your attack strength: ");
            heroStrength = Convert.ToInt32(Console.ReadLine());

            if (heroStrength > monsterStrength)
            {
                Console.WriteLine("You use the Holy Hand Grenade of Antioch " +
                    "and blow the rabbit to tiny bits.");
            }//end if
            else if (heroStrength == monsterStrength)
            {
                //user entered the same number as the monsterStrength
                Console.WriteLine("Alright, then. We'll call it a draw.");
            }//end else if
            //75% of the rabbits strength. if the rabbits strength is 100, this checks for 75-99
            else if (heroStrength >= monsterStrength * 75)
                Console.WriteLine("You die a valiant death, but put up a great fight.");
            else if (heroStrength > 0)
            {
                Console.WriteLine("You join the pile of bones!");
                //because a bool stores a true or false valuse we 
                //can use a bool to ditermine weather or not if statment
                //should or shouldnt run.
                bool runMe = true;

            }
            Console.WriteLine("\nProgram running...\n");

            bool isAdmin = false;
            //Capture userinput to determine if the user should
            //have access to some functionality.

            Console.WriteLine("Enter your username: ");
            string username = Console.ReadLine().ToUpper();

            if (username == "JERMEY" || username == "ADMIN")
            {
                isAdmin = true;

            }
            //end if 
            if (isAdmin = true);
            {
                Console.WriteLine("You're an andmin!");
                //end if
            }

            //NESTED IF: you can NEST if trees inside branches of other 
            //if trees
            Console.WriteLine("Shall we play a game? ");
            string userProgram = Console.ReadLine().ToUpper();

            if (userProgram == "Y" || userProgram == "YES");
            {
                Console.WriteLine("Program Running...");
            }//end if y or yes

            else if (userProgram == "N" || userProgram == "NO") ;
            {
                Console.WriteLine("We didn't want to play ");
{}
                int testScore = 0;

                //end if B
                //70 and over is C
                else if (testScore >= 70)
                {
                    Console.WriteLine("Adequate... C");

                //end if C
                //60 and over is D 
                else if (testScore >= 60)
                    {
                        Console.WriteLine("Poor... D");
                        //end if D
                        else
                        {
                            Console.WriteLine("Dude...Did you even try?");
                        }//end else

                        //The ternary operator is a quick inline if/else statement
                        //Syntax:
                        //BooleanCondition ? codeIfTrue : codeIfFalse
                        Console.Write("How many Daleks are there? ");
                        int dalekCount = int.Parse(Console.ReadLine());
                        Console.WriteLine("Oh, no! {0} Dalek{1}!",
                            dalekCount,
                            dalekCount == 1 ? "" : "s");
                        //isAdmin ? "You're an admin" : :Not an admin";


                        
        }//end Main()SVM
    }//end namespace
}//end class
