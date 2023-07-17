using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssign
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Instantiates the class
            Math obj = new Math();
            // Asks for user input of the first number, and stores it inside a variable
            Console.WriteLine("Please input a number to do a math operation on:");
            int input1 = Convert.ToInt32(Console.ReadLine());
            // This uses a try/catch block to make the second user input optional, where inputting nothing for the second number usually throws an error
            try
            {
                // Asks for user input of the optional second number, and stores it in a variable if inputted. If nothing is entered, instead of throwing an error, it moves to the catch block 
                Console.WriteLine("Optional. Please enter a second number: ");
                int input2 = Convert.ToInt32(Console.ReadLine());
                // Calls the 'operation' method with both inputs
                Console.WriteLine(obj.operation(input1, input2));
            }
            catch
            {
                // Calls the 'operation' method with just the first input
                Console.WriteLine(obj.operation(input1));
            }
            
            // Keeps the printed lines on screen
            Console.ReadLine();

        }
    }
}
