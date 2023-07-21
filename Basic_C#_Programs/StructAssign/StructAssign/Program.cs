using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructAssign
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creates an object of data type 'Number', and assigns a value to the 'Amount' property
            Number number = new Number();
            number.Amount = 4.3m;
            // Wrties the value assigned to 'Amount' to the console, and leaves it on the screen
            Console.WriteLine(number.Amount);
            Console.ReadLine();
        }
    }
}
