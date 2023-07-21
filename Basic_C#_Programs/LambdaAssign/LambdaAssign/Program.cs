using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaAssign
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creates a list of type 'Employee', and adds ten Employee objects with values assigned
            List<Employee> employees = new List<Employee>()
            {
                new Employee(){ Id = 1, FirstName = "Bret", LastName = "Morris"},
                new Employee(){ Id = 2, FirstName = "Lauren", LastName = "Rhodes"},
                new Employee(){ Id = 3, FirstName = "Jerry", LastName = "Smith"},
                new Employee(){ Id = 4, FirstName = "Joe", LastName = "Gatto"},
                new Employee(){ Id = 5, FirstName = "Richard", LastName = "Johnson"},
                new Employee(){ Id = 6, FirstName = "Isabella", LastName = "Parker"},
                new Employee(){ Id = 7, FirstName = "Ronald", LastName = "Jones"},
                new Employee(){ Id = 8, FirstName = "Joe", LastName = "Clark"},
                new Employee(){ Id = 9, FirstName = "Barbara", LastName = "Lawrence"},
                new Employee(){ Id = 10, FirstName = "Finn", LastName = "Jones"}
            };

            // Instatiates a list called 'joes' to store all Employees named 'Joe'
            List<Employee> joes = new List<Employee>();
            // Using a foreach loop and an if statement, iterates through the list 'employees' checking if the 'FirstName' value equals 'Joe', and of so, adds it to the 'joes' list
            foreach (Employee employee in employees)
            {
                if (employee.FirstName == "Joe")
                {
                    joes.Add(employee);
                }
            }
            // This loop prints out the values stored in the 'joes' list
            foreach (Employee employee in joes)
            {
                Console.WriteLine(employee.FirstName + " " + employee.LastName + " " + employee.Id);
            }
            Console.ReadLine();

            // Using a lambda expression, creates a list called 'newList', and iterates through the list 'employees' to check the 'Id' value if it is greater that 5, and if so, adds it to the 'newList' (while using alot less code to to the same thing as above)
            List<Employee> newList = employees.Where(x => x.Id > 5).ToList();
            // This loop prints out the values stored in the 'newList' list
            foreach (Employee employee1 in newList)
            {
                Console.WriteLine(employee1.FirstName + " " + employee1.LastName + " " + employee1.Id);
            }
            Console.ReadLine();

        }
    }
}
