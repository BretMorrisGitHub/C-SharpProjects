using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAssign
{
    class Program
    {
        static void Main(string[] args)
        {
            // This code asks for a number input, puts it in a variable, and sets a counting variable called 'i' for the while loop to keep track
            Console.WriteLine("Input a number to be displayed that many more times.");
            int input = Convert.ToInt32(Console.ReadLine());
            int i = 0;

            // This while loop uses 'i' to keep track of how many times to run the code inside, and every time the code is ran, 1 is added to i, and a sentence is displayed
            while (i != input)
            {
                Console.WriteLine(i + ":" + input);
                i = i + 1;
                
            }
            Console.ReadLine();

            
            // This code asks for a number input, puts it in a variable, and sets a counting variable as well. 
            Console.WriteLine("Input a number to be displayed that many more times.");
            int input2 = Convert.ToInt32(Console.ReadLine());
            int i2 = 0;

            // this code uses a do while statement similarly to the previous code block to function the same
            do
            {
                Console.WriteLine(i2 + ":" + input);
                i2 = i2 + 1;
            }
            while (i2 != input2);
            Console.ReadLine();

        }
    }
}
