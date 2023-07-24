using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeAssign
{
    class Program
    {
        static void Main(string[] args)
        {
            // Gets the current time with the '.Now' method, and stores it in a variable for use
            DateTime currentTime = DateTime.Now;
            // Writes the current time to the console and keeps it on the screen
            Console.WriteLine(currentTime);
            Console.ReadLine();
            
            // Asks the user for a number input, and stores it in a variable
            Console.WriteLine("Please enter a number: ");
            int input = Convert.ToInt32(Console.ReadLine());
            // Creates a new DateTime variable that uses the 'AddHours' method to add however much the value in the variable 'input' is, to the hours stored
            DateTime newTime = currentTime.AddHours(input);
            // Prints the value inside the 'newTime' variable, and keeps it on the screen
            Console.WriteLine(newTime);
            Console.ReadLine();

        }
    }
}
