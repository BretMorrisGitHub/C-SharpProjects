using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchAssign
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please enter your age");
                
            }
            catch 
            {

            }

            int age = Convert.ToInt32(Console.ReadLine());
            
            DateTime currentTime = DateTime.Now;
            DateTime birthYear = currentTime.AddYears(-age);

            Console.WriteLine(birthYear + "You were either born this specified year, or the year before.");
            Console.ReadLine();
        }
    }
}
