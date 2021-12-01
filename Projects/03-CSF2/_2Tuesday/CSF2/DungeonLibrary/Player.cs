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
        }
        //bonus: customize a prop based off of race

        //end FQ CTOR

        //money / methods

        public override string ToString()
        {
            string description = "";

            switch (CharacterRace)
            {
                case Race.Dwarf:
                    description = "Dwarf";
                    break;
                case Race.Elf:
                    description = "Elf";
                    break;
                case Race.Orc:
                    description = "Orc";
                    break;
                case Race.Gnomes:
                    description = "Gnomes";
                    break;
                case Race.Human:
                    description = "Human";
                    break;
                case Race.Furīzashuzoku:
                    description = "Furīzashuzoku";
                    break;
                case Race.Shade:
                    description = "Shade";
                    break;
                case Race.Tiefling:
                    description = "Tiefling";
                    break;
                case Race.Kajhit:
                    description = "Kajhit";
                    break;
            }

            return $"-=-= {Name} =-=-\n" +
            $"Life: {Life} / {MaxLife}\n" +
            $"HitChance: {HitChance}\n" +
            $"Weapon:\n{EquippedWeapon}\n" +
            $"Block: {Block}\n" +
            $"Description: {description}";

            //end ToString() override




        }
    }
}
