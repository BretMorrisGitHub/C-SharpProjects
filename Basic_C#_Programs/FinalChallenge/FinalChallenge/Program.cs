using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var school = new SchoolContext())
            {
                var student = new Student();
                student.FirstName = "Joe";
                student.LastName = "Morley";
                student.Grade = 11;

                school.Students.Add(student);
                school.SaveChanges();
                
            }
        }
    }
}
