using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace InputAssign
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number to be added to a log: ");
            int input = Convert.ToInt32(Console.ReadLine());
            using (StreamWriter file = new StreamWriter(@"C:\Users\legol\logs\log.txt", true))
            {
                file.WriteLine(input);
            }
        }
    }
}
