using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssign
{
    class Math
    {
        // Defines the method 'operation' as a void method with one defined parameter, and an out parameter that is defined inside the method, then outputs an integer from a math operation
        public void Operation(int num, out int num2)
        {
            num2 = 2;
            int answer = num / num2;
            Console.WriteLine(answer);
        }

        // Defines an overloaded void method that requires two arguments, and has two outputs
        public void operation(int num1, int num2)
        {
            int output1 = num1 / 3;
            int output2 = num2 / 3;
            Console.WriteLine(num1 + " divided by 3 equals: " + output1);
            Console.WriteLine(num2 + " divided by 3 equals: " + output2);
        }
    }

}
