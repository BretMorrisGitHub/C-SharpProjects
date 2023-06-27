using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            // Asks for age input and stores it in a vairable
            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());
            
            // Asks if you have had a dui, and stores it in a variable
            Console.WriteLine("Have you ever had a DUI? Type 'True', or 'False'.");
            bool dui = Convert.ToBoolean(Console.ReadLine());
            
            // Asks for number of tickets, and stores it in a variable
            Console.WriteLine("How many speeding tickets do you have?");
            int tickets = Convert.ToInt32(Console.ReadLine());

            // This compares all of the variables using various operators to determine if person is qualified ot not, and displays result
            Console.WriteLine("Qualified?");
            bool qualified = age > 15 && dui == false && tickets <= 3;
            Console.WriteLine(qualified);
            Console.ReadLine();
            

        }
    }
}
