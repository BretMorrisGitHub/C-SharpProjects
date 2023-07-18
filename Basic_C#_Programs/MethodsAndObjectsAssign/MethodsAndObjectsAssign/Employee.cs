using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjectsAssign
{
    // Creates the class 'Employee', while inheriting the properties from the 'Person' class
    public class Employee : Person
    {
        // Creates its own property called 'Id'
        public int Id { get; set; }
    }
}
