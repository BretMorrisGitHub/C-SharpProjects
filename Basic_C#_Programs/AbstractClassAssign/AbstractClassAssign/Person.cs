using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssign
{
    // Creates a class that is abstract, as it is never needed to be instantiated
    public abstract class Person
    {
        // Defines two properties called 'firstName', and 'lastName.
        public string firstName { get; set; }
        public string lastName { get; set; }

        // Creates a method called 'SayName' that puts the values of the name properties together in a readable format to display, and has the keyword 'virtual' so that the method can be implemented in classes that inherit from this class
        public virtual void SayName()
        {
            Console.WriteLine("Name: " + firstName + " " + lastName + ".");
            Console.ReadLine();
        }
    }
}
