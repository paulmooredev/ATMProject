using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1Monday
{
    class NamingConventions
    {
        //NOTE This class has no Main().
        //It could NEVER be used as a start-up object for a console app.
        //It would just be a helper file.

        //If this file was in a special project called a Dynamic Link Library
        //(AKA Class Library) it would build as a .dll instead of a .exe.

        /*
         * Naming conventions are guidelines on how to name things.
         * Breaking them won't generally cause build errors,
         * but it's helpful to be consistent.
         * 
         * lowercase
         * Examples: thisislowercase, namespace, using
         * - RULE: Required C# keywords
         * - This convention could be used anywhere, but generally, is not.
         * 
         * UPPERCASE
         * Example: ONE_RING
         * - Used rarely, most typically with constants to make them stand
         * out. 
         * - use an _ for a space
         * 
         * camelCase
         * Example: thisIsCamelCase, employeeName, firstExample
         * - Uses lowercase letters for the first word and a
         * capitalized first letter for each following word.
         * - Typically, this is used for variables and parameters
         * 
         * PascalCase
         * Examples: ThisIsPascalCase, NamingConventions
         * - Uses an uppercase first letter for every word.
         * - Typically, PascalCase is used for "Everything Else":
         * namespace, class, methods, properties, etc.
         * 
         * Hungarian / Lezinski convention
         * Example: intCustomersInQue, btnClick, lblDisplay, qryAllEmployees
         * 
         * - This looks like camelCase, but the first word is descriptive of 
         * what the object is.
         */
    }
}
