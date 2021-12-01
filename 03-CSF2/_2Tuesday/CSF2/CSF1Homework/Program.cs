
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    class ATM
    {
        static void Main(string[] args)
        {
            #region login
            //for this exercise use the following information
            //acct# 1234
            //PIN# 4321

            int acct;
            int pin;

            int count = 0;
            int pcount = 0;



            Console.WriteLine("************************");
            Console.WriteLine("*    ATM APPLICATION   *");
            Console.WriteLine("************************");
            Console.WriteLine("\n\n\n");


            do
            {
                Console.Write("Enter your account number: ");
                acct = Convert.ToInt32(Console.ReadLine());

                if (acct == 1234)
                {

                    break;
                }//end Acct#IF
                else if (acct != 1234)
                {
                    Console.WriteLine("Invalid Account Number, please try the entry again.");
                    count++;
                }//end acct # else if
            } while ((acct != 1234) && (count != 3));
            if (count == 3)

                Console.WriteLine("attempts exceeded, your account is locked. Please contact customer service.");
            do
            {
                Console.Write("Enter your PIN: ");
                pin = Convert.ToInt32(Console.ReadLine());
                if (pin == 4321)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid PIN entered. Please try again.");
                    pcount++;
                }

            } while ((pin != 4321) && (pcount != 3));
            if (pcount == 3)
                Console.WriteLine("attempts exceeded, your account is locked. Please contact customer service.");
            #endregion

            #region Menu
            Console.Clear();
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("|             Please select from the following menu.                    |");
            Console.WriteLine("*************************************************************************");


            int choice = 0;

            decimal dep;
            decimal withD;
            decimal bal = 0m;
            bool quit = false;
            string answer;

            while (!quit)
            {
                Console.WriteLine(@"
1) Deposit
2) Withdraw
3) Balance Inquiry
E) Exit
");
                string userChoice = Console.ReadLine().ToUpper();
                switch (userChoice)
                {
                    case "1":
                    case "DEPOSIT":
                    case "D":
                        Console.WriteLine("How much would you like to deposit?");
                        dep = Convert.ToUInt32(Console.ReadLine());

                        bal = bal + dep;
                        Console.WriteLine($"{dep:C2} recieved. Your new balance is {bal:C2}. \nWould you like another transaction? Y/N\n");
                        answer = Console.ReadLine().ToUpper();

                        if (answer == "N")
                            quit = true;
                        Console.WriteLine();
                        break;

                    case "2":
                    case "WITHDRAW":
                    case "W":
                        Console.WriteLine("How much money would you like to withdraw?");
                        withD = Convert.ToInt32(Console.ReadLine());
                        if (bal < withD)
                        {
                            Console.WriteLine("You do not have sufficient funds.");
                            break;
                        }
                        bal = bal - withD;
                        Console.WriteLine($" {withD:C2} Withdrawn from your account. Your remaining balance is {bal:C2}. \nWould you like another transaction? Y/N\n");
                        answer = Console.ReadLine().ToUpper();
                        if (answer == "N")
                            quit = true;
                        Console.WriteLine();
                        break;

                    case "3":
                    case "BALANCE":
                    case "B":
                        Console.WriteLine($" Your balance is {bal:C2}.\n Would you like another transaction? Y/N \n");
                        answer = Console.ReadLine().ToUpper();
                        if (answer == "N")
                            quit = true;
                        Console.WriteLine();
                        break;

                    // case "4":
                    case "EXIT":
                    case "E":
                    case "e":
                        quit = true;
                        Console.WriteLine();
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        Console.WriteLine();
                        break;

                }//end SWITCH
            }//end WHILE
            Console.Clear();
            Console.WriteLine("****************************** Mahalo Nui Loa for banking with Aloha Banking Services ******************************");
            #endregion

        }//end MAIN()
    }//end CLASS
}//end NAMESPACE
