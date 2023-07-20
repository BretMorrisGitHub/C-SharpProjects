using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametersAssign
{
    public class Employee<T>
    {
        // Gives the Employee class properties 
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public T things { get; set; }

        // Defining how we want to overload the '==' operator
        //public static bool operator ==(Employee employee1, Employee employee2)
        //{
        //    return employee1.Id == employee2.Id;
        //}

        //// Defining how we want to overload the '!=' operator
        //public static bool operator !=(Employee employee1, Employee employee2)
        //{
        //    return employee1.Id != employee2.Id;
        //}
    }
}
