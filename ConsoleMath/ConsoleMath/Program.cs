using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMath
{
    class Program
    {
        static void Main(string[] args)
        {
            // This block of code uses the multiplication operator '*' to multiply a number given from the user stored in variables
            Console.WriteLine("Input a number to be multiplied by 50:");
            int input1 = Convert.ToInt32(Console.ReadLine());
            int sum1 = input1 * 50;
            
            // This block of code uses string concatenation with the variables to write a sentence to the user that they can understand
            Console.WriteLine(input1 + " multiplied by 50 is " + sum1);
            Console.ReadLine();

            // This block of code uses the addition operator '+' to add a number given from the user stored in variables
            Console.WriteLine("Input a number that will be add 25 to it:");
            int input2 = Convert.ToInt32(Console.ReadLine());
            int sum2 = input2 + 25;

            // This block of code uses string concatenation with the variables to write a sentence to the user that they can understand
            Console.WriteLine(input2 + " plus 25 equals " + sum2);
            Console.ReadLine();

            // This block of code uses the division operator '/' to divide a number given from the user stored in variables
            Console.WriteLine("Input a number that will be divided by 12.5:");
            int input3 = Convert.ToInt32(Console.ReadLine());
            double sum3 = input3 / 12.5;

            // This block of code uses string concatenation with the variables to write a sentence to the user that they can understand
            Console.WriteLine(input3 + " divided by 12.5 equals " + sum3);
            Console.ReadLine();

            // This block of code uses a comparative operator to find out is the inputed number is greater than 50
            Console.WriteLine("Input a number to be checked if it is greater than 50:");
            int input4 = Convert.ToInt32(Console.ReadLine());
            bool compare = input4 > 50;

            // This block of code uses string concatenation with the variables to write a sentence to the user that they can understand
            Console.WriteLine(compare);
            Console.ReadLine();

            // This block of code uses the modulus operator '%' to divide a number given from the user stored in variables, and only bring back the remainder
            Console.WriteLine("Input a number that will be divided by 7, then the remainder will be outputed:");
            int input5 = Convert.ToInt32(Console.ReadLine());
            int sum4 = input5 % 7;

            // This block of code uses string concatenation with the variables to write a sentence to the user that they can understand
            Console.WriteLine(input5 + " divided by 7, with a remainder of " + sum4);
            Console.ReadLine();

        }
    }
}
