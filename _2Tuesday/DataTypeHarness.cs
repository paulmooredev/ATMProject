using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//you must add a reference to an outside librbary to access it
//You can add a using statement to make it easier to use.
using SignaturesLibrary;
using Charity;

namespace _2Tuesday
{
    class DataTypeHarness
    {
        static void Main(string[] args)
        {
            Signature.Header("Datatype Test Harness");


            /*
             * Sometimes , we call a program that test the functionallity
             * of other code we create a "test harness."
             * In this test harness, we will test some new custom complex data types
             * All of the classes will be built in seperate Class Library project
             * and tested here.
             */
            Volunteer v1 = new Volunteer();
            v1.Name = "Spider Man";
            v1.IsActive = true;
            v1.YearsOfService = 12;

            //Complex datatypes use the NEW keyboard to call
            //the "constructor." (a method that builds the object.)
            //If you dont
            Console.WriteLine($"{v1.Name} has volunteered for {v1.YearsOfService} years.\n" + 
                $"Still Active? { v1.IsActive}");

            //MINI-LAB!
            //Create a new Volunteer object,
            //Populate its fields and display value

            Volunteer v2 = new Volunteer();
            v2.Name = "Doctor Octopus";
            v2.IsActive = false;
            v2.YearsOfService = 15;
                                 
            #region Organization
            Console.WriteLine("\n\n*** ORGANIZATION STUFF ***\n\n");

            //collect  / constructors (ctors)
            /*
             * constructors are specialized methods used to create objects
             * of this type we call constructors using the "new" keyword.
             * The constructor method always has the same name as the data type (class name)
             * where it is defined.
             * NO return type is listed in constructor method signatures.
             * 
             * If you dont create your own ctor, youll get a free
             * default paramterless ctor.
             * 
             * When you do create your own ctor, you loose the freeone
             * unless you rebuild it.
             */
            


        }
    }
}