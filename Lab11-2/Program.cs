using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = new List<Student>
            {
            new Student
            {
                Age = 18,
                FirstName = "Anastasia",
                LastName = "Strizh"

            },
             new Student
            {
                Age = 20,
                FirstName = "Irina",
                LastName = "Akopyan"

            },
              new Student
            {
                Age = 15,
                FirstName = "Leonid",
                LastName = "Kovalsky"

            },
               new Student
            {
                Age = 21,
                FirstName = "Maria",
                LastName = "Timmerman"

            },
                new Student
            {
                Age = 19,
                FirstName = "Natalia",
                LastName = "Anichkina"

            },
                 new Student
            {
                Age = 51,
                FirstName = "Pavel",
                LastName = "Lapshin"

            },
            };

            students = students.FindStudent(
                (student) =>
                {
                    return Student.IsAdult(student);
                }
                );

            students = students.FindStudent(
                (student) =>
                {
                    return Student.IsLastNameBigger3(student);
                }
                );

            students = students.FindStudent(
                (student) =>
                {
                    return Student.IsNameStartA(student);
                }
                );

            foreach (var student in students)
            {
                Console.WriteLine(student.Age);
                Console.WriteLine(student.FirstName);
                Console.WriteLine(student.LastName);
            }
        }
    }
}
