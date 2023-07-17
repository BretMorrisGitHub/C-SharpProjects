using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssign
{
    class Program
    {
        public static void Main(string[] args)
        {
            Math obj = new Math();
            Console.WriteLine("Please input a number to do a math operation on:");
            int input1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Would you like to input a second number: True or False?");
            bool input2 = Convert.ToBoolean(Console.ReadLine());
            if (input2)
            {
                Console.WriteLine("Please input second number:");
                int input3 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(obj.operation(input1, input3));
            }
            else
            {
                Console.WriteLine(obj.operation(input1));
            }
            
            //Console.WriteLine(obj.operation(input1, input2));
            Console.ReadLine();

        }
    }
}
