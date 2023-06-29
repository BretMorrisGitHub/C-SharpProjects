using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAssign
{
    class Program
    {
        static void Main(string[] args)
        {
            //string x = "This is string 1, ";
            //string y = "this is string 2, ";
            //string z = "and this is string 3!";

            //string xyz = x + y + z;
            //xyz = xyz.ToUpper();

            //Console.WriteLine(xyz);
            //Console.Read();

            StringBuilder paragraph = new StringBuilder();

            paragraph.Append("Strings are what they call immutable, meaning they cannot be changed after they have been created.");
            paragraph.Append(" So if you attempt to change the value of a string variable, all it does is change all of the data that is allocated in memory for that variable, even if you just changed one character.");
            paragraph.Append(" An issue that can heppen, is if you are changing alot of string variables, like in the tens of thousands, you can experience long wait times, and your computer running out of memory");
            paragraph.Append(" To solve this, the developers of C# added the StringBuilder class, a dynamic object that allows you to make changes to a string variable, while not using too much hardware resources.");

            Console.WriteLine(paragraph);
            Console.Read();

        }
    }
}
