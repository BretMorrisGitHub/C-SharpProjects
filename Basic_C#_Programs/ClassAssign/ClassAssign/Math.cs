using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssign
{
    class Math
    {
        // Defines the method 'operation' as a void method with one parameter, and outputs an integer from a math operation
        public void operation(int num)
        {
            int output = num / 2;
            Console.WriteLine(output);
        }

        // Defines an overloaded static void method that has requires two arguments, and has two outputs
        public static void operation(int num1, int num2)
        {
            int output1 = num1 / 3;
            int output2 = num2 / 3;
            Console.WriteLine(num1 + " divided by 3 equals: " + output1);
            Console.WriteLine(num2 + " divided by 3 equals: " + output2);
        }
    }

}
