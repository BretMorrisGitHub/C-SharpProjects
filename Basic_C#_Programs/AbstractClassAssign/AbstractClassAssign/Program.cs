using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssign
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiates an Employee object with the first and last name values 'Sample', and 'Student'
            Employee employee = new Employee();
            employee.firstName = "Sample";
            employee.lastName = "Student";
            // Calls the 'SayName' method on the object 
            employee.SayName();
        }
    }
}
