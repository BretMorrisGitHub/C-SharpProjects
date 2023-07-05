using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethodsAssign
{
    class Program
    {
        static void Main(string[] args)
        {
            // This code creates an instance of the math class to be used
            math obj = new math();
            // Asks for user input, to be stored in a variable
            Console.WriteLine("Input your number to do math operations on:");
            int input = Convert.ToInt32(Console.ReadLine());
            // Uses the methods defined in the class with the user input as the parameter
            Console.WriteLine(obj.multiplication(input));
            Console.WriteLine(obj.division(input));
            Console.WriteLine(obj.addition(input));
            Console.ReadLine();

        }
    }
}
