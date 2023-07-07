using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssign
{
    class Program
    {
        static void Main(string[] args)
        {
            // This code creates an instance of the math class to be used
            math obj = new math();
            // Asks for user input, to be stored in a variable
            Console.WriteLine("Input your number to do math a operation on it:");
            int input = Convert.ToInt32(Console.ReadLine());
            // Uses the methods defined in the class with the user input as the parameter
            Console.WriteLine(obj.operation(input));
            Console.ReadLine();

            // Asks for user input, to be stored in a variable
            Console.WriteLine("Input a decimal number bigger than 3 to do math a operation on it:");
            decimal input1 = Convert.ToDecimal(Console.ReadLine());
            // Uses the methods defined in the class with the user input as the parameter
            Console.WriteLine(obj.operation(input1));
            Console.ReadLine();

            // Asks for user input, to be stored in a variable
            Console.WriteLine("Input a number as a string to do math a operation on it:");
            string input2 = Convert.ToString(Console.ReadLine());
            // Uses the methods defined in the class with the user input as the parameter
            Console.WriteLine(obj.operation(input2));
            Console.ReadLine();

        }
    }
}
