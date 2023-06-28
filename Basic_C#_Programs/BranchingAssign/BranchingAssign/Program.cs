using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchingAssign
{
    class Program
    {
        static void Main(string[] args)
        {
            // This block of code greets the user and asks for the package weight, stores it in a variable, and uses an if statement to check if the weight is more than 50
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("Please enter the package weight:");
            int weight = Convert.ToInt32(Console.ReadLine());
            if (weight > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                Console.ReadLine();
                return;
            }

            // This code asks for the width of the package and stores it in a variable
            Console.WriteLine("Please enter package width:");
            int width = Convert.ToInt32(Console.ReadLine());

            // This code asks for the height of the package and stores it in a variable
            Console.WriteLine("Please enter package height:");
            int height = Convert.ToInt32(Console.ReadLine());

            // This code asks for the length of the package and stores it in a variable
            Console.WriteLine("Please enter package length:");
            int length = Convert.ToInt32(Console.ReadLine());

            // Uses math operators to help find a factor determining the shipping cost
            int total = width + height + length;

            // An if statement seeing if the variable 'total' is more than 50
            if (total > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                Console.ReadLine();
                return;
            }

            // Uses math operators to determine the shipping cost
            decimal quote = Convert.ToDecimal(width * height * length * weight / 100f);

            // Writes to the console the estimated shipping cost for the user
            Console.WriteLine("Your estimated total for shipping this package is: $" + quote);
            Console.WriteLine("Thank you!");
            Console.ReadLine();
        }
    }
}
