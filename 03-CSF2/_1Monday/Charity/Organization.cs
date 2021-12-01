using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charity
{
    class Organization
    {
        public Organization(string name, DateTime dateFounded),
                int nbrOfMembers, decimal revenue)
            {
                //The params above should always be named in camelCase

        //Here is where the code goes to assign the arguments the passed.
        //We caught those arguments in our paramaters to the appropriate
        //Property = parameter
        //PascalCase = camelCase;
        Name = name;
            }
    DateFounded = datefounded;
                NbrOfMembers = nbrOfMembers
                Revenue = revenue;
    //end fullly qualified constructor (FQ CTOR), has a parameter for each property.
    //default, paraeterless ctor, recreated
    public Organization() { }//done!
                             //since we accepted no params, we had no work to do in the body (scope)

    //money / methods
    //these actions are related to or using properties of our object.
    //Most common method is to override the ToString().



    public override string ToString()
    {
        //return.base to string
        //the base.ToString() gives us th edefault 



        return string.Format($"Organization: {Name}\n" +
                            $"Revenue: {Revenue:c}\n" +
                            $"Members: {NbrOfMembers:n0}\n");
        }
    }
}
