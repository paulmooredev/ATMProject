using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;//added 

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

            Console.WriteLine("Your journey begins....\n");

            int score = 0;

            //TODO 1. Create a Player

            //TODO 2. Create a Weapon for the Player
            Weapon sword = new Weapon(1, 8, "Short Swor", 10, false);

            Player player = new Player("Leeroy Jenkins", 70, 5, 40, 40, Race.Elf, sword);
            //TODO 3. Add Customization based on player race

            //4. Create a loop for the room and monster

            bool exit = false;
            do
            {
                //enter the room

                //5. Get a room description from a custom method that generates them
                Console.WriteLine(GetRoom());
                //TODO 6. Create a monster in the room for the Player to battle.
                //Learn about creating objects and randomly selecting them

                //7. Create a loop for the user choice menu (inner loop)
                bool reload = false;
                do
                {
                    //8. Create a menu of options
                    Console.WriteLine(@"
Please choose an action:
A) Attack
R) Run Away
P) Player Info
M) Monster Info
X) Exit
");
                    //9. Capture user choice.
                    string userChoice = Console.ReadKey(true).Key.ToString();

                    Console.Clear();
                    //10. Perform an action based on the users input
                    switch (userChoice)
                    {
                        case "A":
                            //TODO 11. Create attack/battle functionality

                            //TODO 12. Handle if the user wins

                            Console.WriteLine("Attack Method Goes Here...");
                            break;

                        case "R":
                            //TODO 13. Give the monster a free attack
                            Console.WriteLine("Run Away!!");
                            reload = true; //"re"load a new room
                            break;

                        case "P":
                            Console.WriteLine("Player Info:");
                            //TODO 14. Display Player info
                            Console.WriteLine(player);
                            Console.WriteLine("Monsters slain " + score);
                            break;

                        case "M":
                            Console.WriteLine("Monster Info:");
                            //TODO 15. Display Monster info
                            break;

                        case "X":
                        case "E":
                        case "Escape":
                            Console.WriteLine("No one likes a quitter....");
                            exit = true;
                            break;

                        default:
                            Console.WriteLine("Thou hast chosen an invalid option.");
                            break;
                    }//end switch

                    //TODO 16. Check Player Life

                } while (!reload && !exit);
                //While reload and exit are BOTH NOT TRUE, keep looping.
                //If reload is true, leave the inner loop. If exit is true, leave both loops.
            } while (!exit);//While exit is NOT TRUE, keep looping

            Console.WriteLine($"" +
                $"You defeated {score:n0} monster{(score == 1 ? "." : "s.")}");

        }//end Main()

        #region Custom Methods
        private static string GetRoom()
        {
            string[] rooms =
            {
                "Room 1",
                "Room 2",
                "Room 3",
                "Room 4",
                "Room 5",
                "Room 6"
            };
            //MINI-LAB
            //Finish the string array, and return one of the room descriptions.
            //Random rand = new Random();

            //int indexNbr = rand.Next(rooms.Length);

            //string room = rooms[indexNbr];

            //return room;

            //refactored
            return rooms[new Random().Next(rooms.Length)];


        }

        #endregion
    }//end class
}//end namespace
