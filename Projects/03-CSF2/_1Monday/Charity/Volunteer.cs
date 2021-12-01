using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charity
{
    /*
     * This class librbary project (Charity) is intended to store classess
     * to be consumed elsewhere in the application. Storeing them here makes the application
     * more modular (all of the Charity Classes are in one place) and reusable (all of 
     * the classes can be used anywhere else in the application)/
     * 
     * In order to use the in another project, we have to ensure that the class we want
     * to use are public, the consuming project has a refernce to this project, and optionally,
     * that ay consuming class has a "using" statement for this namespace.
     */
    public class Volunteer
    {
        //DATA TYPE CLASS - It gets no SVM. It is intended to be a blueprint
        //to make other objects. 

        //Fields (aka attributes): Represents information stored for an object of
        //"this" type.
        //Naming conventions: _camelCase
        //Access modifier: private

        //Fields are just variables.
        private string _name;
        private byte _yearsOfService;
        private bool _isActive;

        //Properties (props): Control access to the fields
        //Naming convention: The PascalCase version of the field name.
        //Access modifier: public 

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public byte YearsOfService
        {
            get { return _yearsOfService; }
            set { _yearsOfService = value; }
        }

        public bool IsActive
        {
            get { return _isActive; }
            set { _isActive = value; }
        }
        //Fields and props work together to store information about objects.
        //The fields store the information.
        //The props pass the info back and forth.
    }
}
