using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



    class Program
{
    static void Main()
    {
        //This block of code creates an array of strings, asks the user for input to choose which index of the array to choose from, stores it in a variable, and displays it to the user after going through an if else statement, which makes sure the user chooses an idex that exists
        string[] array = new string[] { "Bret", "Jack", "Jerry", "Cathrine", "Bob" };
        Console.WriteLine("Please choose a number between 0-5 to choose the index from an array of strings.");
        int index = Convert.ToInt32(Console.ReadLine());
        if (index > 6)
        {
            Console.WriteLine("That index does not exist.");
            Console.ReadLine();
            return;
        }
        else
        {
            Console.WriteLine(array[index]);
            Console.ReadLine();
        }

        //This block of code creates an array of integers, asks the user for input to choose which index of the array to choose from, stores it in a variable, and displays it to the user after going through an if else statement, which makes sure the user chooses an idex that exists
        int[] array1 = new int[] { 932, 178, 478, 282, 912 };
        Console.WriteLine("Please choose a number between 0-5 to choose the index from an array of integers.");
        int index1 = Convert.ToInt32(Console.ReadLine());
        if (index1 > 6)
        {
            Console.WriteLine("That index does not exist.");
            Console.ReadLine();
            return;
        }
        else
        {
            Console.WriteLine(array1[index1]);
            Console.ReadLine();
        }

        // This code creates a list of strings, asks the user to input the index of their choice, makes sure the index exists with an if else statement, then displays the value from the index they chose from the list
        List<string> strings = new List<string>();
        strings.Add("Portland");
        strings.Add("Tigard");
        strings.Add("Tualatin");
        strings.Add("Wilsonville");
        strings.Add("Lake Aswego");

        Console.WriteLine("Please choose a number between 0-5 to choose the index of a list of strings of some cities in oregon.");
        int index2 = Convert.ToInt32(Console.ReadLine());
        if (index2 > 6)
        {
            Console.WriteLine("That index does not exist");
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine(strings[index2]);
            Console.ReadLine();
        }


    }
}

