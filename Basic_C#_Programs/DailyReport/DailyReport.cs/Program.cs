using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyReport.cs
{
    class Program
    {
        static void Main()
        {
            // all of these blocks of code writes a specified line in the console, and has the console keep the line open until enter is pressed to move on
            Console.WriteLine("The Tech Academy.");
            Console.ReadLine();

            Console.WriteLine("Student Daily Report.");
            Console.ReadLine();

            // all of these blocks of code writes a specified line in the console, and has the console keep the line open until enter is pressed to move on, and stores the input into a specified variable
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine(name);

            Console.WriteLine("What course are you on?");
            string course = Console.ReadLine();
            Console.WriteLine(course);

            Console.WriteLine("What page number?");
            string pageNumber = Console.ReadLine();
            Console.WriteLine(pageNumber);

            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\".");
            string help = Console.ReadLine();
            Console.WriteLine(help);

            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics?");
            string positives = Console.ReadLine();
            Console.WriteLine(positives);

            Console.WriteLine("Is there any other feedback you'd like to provide? Please be speficic.");
            string feedback = Console.ReadLine();
            Console.WriteLine(feedback);

            Console.WriteLine("How many hours did you study today?");
            string hours = Console.ReadLine();
            Console.WriteLine(hours);

            // this block of code writes a final message, and keeps it on the console 
            Console.WriteLine("Thank you for your answers. An instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();

        }
    }
}
