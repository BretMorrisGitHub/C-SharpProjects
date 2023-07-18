using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssign
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instatiates the class into an object
            Math obj = new Math();
            // Asks the user for input, and stores it inside a variable
            Console.WriteLine("Please enter a number to be divided by 2:");
            int input = Convert.ToInt32(Console.ReadLine());
            // Calls the method 'operation' with the user input as the argument
            obj.Operation(input, out int num2);
            // Keeps the console from closing automatically 
            Console.ReadLine();

            // Asks the user for more number inputs, and stores them in variables
            Console.WriteLine("Please enter a number to be divided 3: ");
            int input1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter a second number to be divided 3: ");
            int input2 = Convert.ToInt32(Console.ReadLine());
            // Calls the method using the class name, as it is set to static
            obj.operation(input1, input2);
            Console.ReadLine();

            Console.WriteLine("Please enter a number to be multiplied by 13: ");
            int input3 = Convert.ToInt32(Console.ReadLine());
            StaticClass.Multiplication(input3);
            Console.ReadLine();
        }
    }
}
