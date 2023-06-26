using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousIncome
{
    class Program
    {
        static void Main(string[] args)
        {
            // Displays the name of the application
            Console.WriteLine("Anonymous Income Comparison Program");

            // This block of code asks for some input about person 1 that will be stored inside variables to use later
            Console.WriteLine("Person 1");
            Console.WriteLine("Please enter your hourly rate:");
            int pay = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter hours worked per week:");
            int hours = Convert.ToInt32(Console.ReadLine());

            // This block of code asks for some input about person 2 that will be stored inside variables to use later
            Console.WriteLine("Person 2");
            Console.WriteLine("Please enter your hourly rate:");
            int pay2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter hours worked per week:");
            int hours2 = Convert.ToInt32(Console.ReadLine());
            
            // This block of code finds the annual pay of person 1 with the variables defined from the previous blocks of code, using math operators, and stores it in a variable for displaying later
            Console.WriteLine("Annual salary of Person 1:");
            int annualPay = pay * hours * 52;
            Console.WriteLine("$" + annualPay);
            Console.ReadLine();

            // This block of code finds the annual pay of person 2 with the variables defined from the previous blocks of code, using math operators, and stores it in a variable for displaying later
            Console.WriteLine("Annual salary of Person 2:");
            int annualPay2 = pay2 * hours2 * 52;
            Console.WriteLine("$" + annualPay2);
            Console.ReadLine();

            // This code compares the annual pays of person 1 and 2, and displays if person one makes more than person 2 with either a true or false
            bool compare = annualPay > annualPay2;
            Console.WriteLine("Does Person 1 make more money than Person 2? " + compare + ".");
            Console.ReadLine();

        }
    }
}
