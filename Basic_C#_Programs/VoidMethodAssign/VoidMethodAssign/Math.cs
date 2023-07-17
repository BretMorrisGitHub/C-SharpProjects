using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidMethodAssign
{
    class Math
    {
        // Defines the method in this class
        public void operation(int num1, int num2)
        {
            // Does a math operation on the first given parameter
            int answer = num1 * 3;
            
            // Writes to the console the answer to the math operation in a way the user can understand
            Console.WriteLine(num1 + " times 3 is equal to " + answer);
            // Wtires to the console the second parameter given
            Console.WriteLine(num2 + " is the second number given.");
            // Keeps the lines on the console 
            Console.ReadLine();
        }
    }
}
