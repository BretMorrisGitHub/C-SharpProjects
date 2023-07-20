using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnumsAssign
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Asks the user for input of the current day of the week, and stores it in a variable
                Console.WriteLine("Please enter the current day of the week: ");
                string input = Convert.ToString(Console.ReadLine());
                // Uses 'Enum.Parse' method to parse through the all of the values in the enum using the users input, and prints it if succsessful 
                Days.DaysOfTheWeek day = (Days.DaysOfTheWeek)Enum.Parse(typeof(Days.DaysOfTheWeek), input);
                Console.WriteLine(day);
                Console.ReadLine();
            }
            // Tells user if they did not enter a day of the week correctly
            catch
            {
                Console.WriteLine("Please enter an actual day of the week.");
                Console.ReadLine();
            }
            
            
            
            

        }
    }
}
