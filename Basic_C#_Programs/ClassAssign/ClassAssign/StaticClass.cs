using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssign
{
    static class StaticClass
    {
        // Defines a static method inside a static class, that takes in input, does a math operation on it, and outputs the answer
        public static void Multiplication(int num)
        {
            int answer = num * 13;
            Console.WriteLine(answer);
        }
    }
}
