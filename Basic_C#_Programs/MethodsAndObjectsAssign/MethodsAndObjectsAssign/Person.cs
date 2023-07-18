using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjectsAssign
{
    public class Person
    {
        // Makes a property called 'FirstName'
        public string FirstName { get; set; }
        // Makes a property called 'LastName'
        public string LastName { get; set; }

        // Defines a method called 'SayName' that will print out the property values of 'FirstName', and 'LastName'
        public void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName + ".");
        }
    }
}
