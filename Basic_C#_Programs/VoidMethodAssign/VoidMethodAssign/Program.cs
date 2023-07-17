using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidMethodAssign
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instatiates the class 'Math'
            Math obj = new Math();
            // Calls the method in the class passing in two numbers
            obj.operation(23, 46);

            // Asks user for input of two numbers, and stores them as variables named 'input1', and 'input2'.
            Console.WriteLine("Please enter a number: ");
            int input1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter a second number: ");
            int input2 = Convert.ToInt32(Console.ReadLine());

            // Calls the method with the two variables as the parameters
            obj.operation(input1, input2);
        }
    }
}
