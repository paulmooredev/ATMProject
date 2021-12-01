using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Player
    {
        //frugal / fields
        private int _life;
        //We only need to create fields for the ones we will have business rules on

        //people / properties
        //Automatic properties, they are a shortcut syntax
        //that allows you to create a shortend version of a public property.
        //The have an "open" getter and setter! The guard is asleep!
        //Auto props automatically create default fields for you at runtime.
        public string Name { get; set; }
        public int HitChance { get; set; }
        public int Block { get; set; }
        public int MaxLife { get; set; }
        //TODO 17. Create a Race
        public Race CharacterRace { get; set; }
        public Weapon EquippedWeapon { get; set; }

        //You can not have business rules with an auto prop
        public int Life
        {
            get { return _life; }
            set
            {
                if (value <= MaxLife)
                    _life = value;
                else
                    _life = MaxLife;
            }
        }
        public Player(string name, int hitChance, int block, int life, int maxLife,
         Race characterRace, Weapon equippedWeapon)
        {
            //Assignment: Pascal 
            MaxLife = maxLife;
            Name = name;
            Life = life;
            CharacterRace = characterRace;
            EquippedWeapon = equippedWeapon;
            Block = block;
            //money / methods






        }
    }//end class
}//end namespace

