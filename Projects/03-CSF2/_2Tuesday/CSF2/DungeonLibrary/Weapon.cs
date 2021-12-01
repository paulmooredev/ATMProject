using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    //new classes default to internal. We must make it public inorder to
    //access it from outside the project.
    public class Weapon
    {
        //frugal / fields
        private int _minDamage;

        //people / properties
        //Properties with business rules should go last
        public int MaxDamage { get; set; }
        public string Name { get; set; }
        public int BonusHitChance { get; set; }
        public bool IsTwoHanded { get; set; }

        public int MinDamage
        {
            get { return _minDamage; }
            set
            {
                //value cant be more than the max damage 
                //and cannot be less than 1.

                if (value > 0 && value <= MaxDamage)
                {

                    //you're good
                    _minDamage = value;
                }
                else
                {

                    _minDamage = 1;
                }
            }
        }

        public object BonsHitChance { get; private set; }


        //collect / constructors
        public Weapon(int minDamage, int maxDamage, string name,
            int bounusHitChance, bool isTwoHanded)
        {
            //If you have any properties that have beusiness rules,
            //that are based off of any other properties,
            //set the other properties first.
            MaxDamage = maxDamage;//Since MinDamage depends on Max, set Max first!
            MinDamage = minDamage;
            BonusHitChance = BonusHitChance;
            IsTwoHanded = isTwoHanded;
        }//fully qualified ctor (FQ CTOR)
        //NO DEFAUKT CTOR
        //we dont want anyone to create a blank weapon, and they only initialize some of
        //the info.


        //money / methods
        public override string ToString()
        {
            return $"{Name}\t{MinDamage} - {MaxDamage} Damage\n" +
                $"Bonus Hit: {BonsHitChance}%\t" +
                $"{(IsTwoHanded ? "Two-Handed" : "One-Handed")}";
            //end ToString() override
        }
    }
}
    
    


