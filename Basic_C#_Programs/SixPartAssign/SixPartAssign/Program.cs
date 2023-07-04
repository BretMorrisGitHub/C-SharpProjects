using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixPartAssign
{
    class Program
    {
        static void Main(string[] args)
        {
            // Assignment Part 1
            // This code creates a string array to be iterated through using for loops with the '<' operator as the comparison
            string[] array1 = new string[] { "Bret ", "Jesse ", "Isaac ", "Johnny ", "Jennifer ", "Rebecca ", "Emily " };
            Console.WriteLine("Please enter a last name to be added into an array of first names:");
            string input = Convert.ToString(Console.ReadLine());

            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = array1[i] + input;
            }

            for (int i = 0; i < array1.Length; i++)
            {
                Console.WriteLine(array1[i]);
            }
            Console.ReadLine();


            // Assignemnt Part 2
            // This code creates an infinite loop, then tells how to fix the infinte loop
            bool X = true;
            while (X)
            {
                Console.WriteLine("Infinite loop");
                // Adding this code will stop the loop after the first iteration
                X = false;
            }
            Console.ReadLine();


            // Assignment Part 3
            // A for loop using the '<' operator as the comparison
            int[] array2 = new int[] { 817, 192, 671, 178, 202, 382, 743, 831, 381, 531 };
            for (int i = 0; i < array2.Length; i++)
            {
                Console.WriteLine(array2[i]);
            }
            Console.ReadLine();

            // A for loop using the '<=' operator as the comparison
            for (int i = 0; i <= 100; i = i + 2)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();

            //Assignment Part 4
            // This code creates a list of strings to be iterated through, asks the user for input, and checks to see if the list has what the user inputted, then tells the user if their input is in the list by displaying the index.
            List<string> list1 = new List<string>();
            list1.Add("Toyota");
            list1.Add("Dodge");
            list1.Add("Ford");
            list1.Add("Kia");
            list1.Add("Chevrolet");
            list1.Add("Hyundai");
            list1.Add("Fiat");

            Console.WriteLine("Please enter a car brand to be searched for in our list of car brands: ");
            string input1 = Convert.ToString(Console.ReadLine());
            bool onList = false;
            for (int i = 0; i < list1.Count; i++)
            {
                if (list1[i].Contains(input1))
                {
                    Console.WriteLine(i);
                    onList = true;
                }

            }
            if (onList == false)
            {
                Console.WriteLine("Your input is not on the list.");
            }
            Console.ReadLine();

            // Assignment Part 5
            // This code also creates a list of strings, and asks the user for input, and displays the indices if what they inputted is in the list, even if it has duplicates 
            List<string> list2 = new List<string>();
            list2.Add("Toyota");
            list2.Add("Dodge");
            list2.Add("Ford");
            list2.Add("Kia");
            list2.Add("Chevrolet");
            list2.Add("Chevrolet");
            list2.Add("Hyundai");
            list2.Add("Fiat");

            Console.WriteLine("Please enter a car brand to be searched for in our list of car brands: ");
            string input2 = Convert.ToString(Console.ReadLine());
            bool onList1 = false;
            for (int i = 0; i < list2.Count; i++)
            {
                if (list2[i].Contains(input2))
                {
                    Console.WriteLine(i);
                    onList1 = true;
                }

            }
            if (onList1 == false)
            {
                Console.WriteLine("Your input is not on the list.");
            }
            Console.ReadLine();


            // Assignment Part 6
            // This code creates a list to be checked if there are duplicates by makeing an empty list and adding to it using some if statements and comparisons
            List<string> list3 = new List<string>();
            list3.Add("A");
            list3.Add("B");
            list3.Add("C");
            list3.Add("D");
            list3.Add("E");
            list3.Add("F");
            list3.Add("E");
            list3.Add("H");
            list3.Add("I");
            list3.Add("J");

            List<string> dupeList = new List<string>();
            foreach (string value in list3)
            {
                if (dupeList.Contains(value))
                {
                    Console.WriteLine(value + " is a duplicate.");
                }
                else
                {
                    dupeList.Add(value);
                    Console.WriteLine(value + " is unique.");
                }
            }
            Console.ReadLine();



        }
    }
}
