using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsAssign
{
    public class Employee
    {
        // Gives the Employee class properties 
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Defining how we want to overload the '==' operator
        public static bool operator== (Employee employee1, Employee employee2)
        {
            return employee1.Id == employee2.Id;
        }

        // Defining how we want to overload the '!=' operator
        public static bool operator!= (Employee employee1, Employee employee2)
        {
            return employee1.Id != employee2.Id;
        }
    }
}
