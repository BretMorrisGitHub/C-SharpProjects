using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjectsAssign
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instatiates and initializes an Employee object with the values 'Sample', and 'Student'.
            Employee employee = new Employee();
            employee.FirstName = "Sample";
            employee.LastName = "Student";
            // Calls the superclass method 'SayName' from the inherited class 'Person'
            employee.SayName();
            // Keeps the printed lines on the screen
            Console.ReadLine();
        }
    }
}
