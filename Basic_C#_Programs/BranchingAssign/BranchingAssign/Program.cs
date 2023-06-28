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
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("Please enter the package weight:");
            int weight = Convert.ToInt32(Console.ReadLine());
            if (weight > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                Console.ReadLine();
                return;
            }

            Console.WriteLine("Please enter package width:");
            int width = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Please enter package height:");
            int height = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter package length:");
            int length = Convert.ToInt32(Console.ReadLine());

            int total = width + height + length;

            if (total > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                Console.ReadLine();
                return;
            }

            decimal quote = Convert.ToDecimal(width * height * length * weight / 100);

            Console.WriteLine("Your estimated total for shipping this package is: $" + quote);
            Console.WriteLine("Thank you!");
            Console.ReadLine();
        }
    }
}
