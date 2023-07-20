using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametersAssign
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiates an employee object with its properties given values 
            //Employee employee1 = new Employee();
            //employee1.FirstName = "Bret";
            //employee1.LastName = "Morris";
            //employee1.Id = 1;

            // Instantiates another employee object with different values 
            //Employee employee2 = new Employee();
            //employee2.FirstName = "Bob";
            //employee2.LastName = "Smith";
            //employee2.Id = 2;

            Employee<string> employee = new Employee<string>();
            employee.things = 

            //// Uses the overloaded operator '==' to compare the employee objects
            //bool compare = employee1 == employee2;
            //Console.WriteLine("Are these employees the same: " + compare);
            //Console.ReadLine();

            //// Uses the overloaded operator '!=' to compare the employee objects
            //bool compare1 = employee1 != employee2;
            //Console.WriteLine("Are these employees not the same: " + compare1);
            //Console.ReadLine();
        }
    }
}
