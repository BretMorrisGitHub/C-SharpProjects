using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppStringsAndIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Here the main code is stored in a try block for exception handling. In this code, a list of integers is created, and asks the user for input for all the numbers in the list to be divided by. The code makes use of a for loop to iterate through the list.
            try
            {
                List<int> list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25 };
                Console.WriteLine("Please enter a number:");
                int input = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < list.Count; i++)
                {
                    int answer = list[i] / input;
                    Console.WriteLine(answer);
                }
                
            }
            // Here are catch blocks for various exceptions to be handled for the best user experience.
            catch (FormatException ex)
            {
                Console.WriteLine("Please type a whole number. " + ex.Message);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Please do not divide by zero. " + ex.Message);
            }
            // Here is a finally block, 
            finally
            {
                Console.WriteLine("End of try/catch block.");
                Console.ReadLine();
            }

        }
    }
}
