using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssign
{
    // Creates a class that inherits from the 'Person' class
    public class Employee : Person, IQuittable
    {
        // Implements the 'SayName' method from the 'Person' class using the override keyword
        public override void SayName()
        {
            
            Console.WriteLine("Name: " + firstName + " " + lastName + ".");
            Console.ReadLine();
            
        }
        // Defines the 'Quit' method inherited from the 'IQuittable' interface
        public void Quit()
        {
            Console.WriteLine("Employee has decided to quit.");
        }
    }
}
