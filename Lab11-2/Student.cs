using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11_2
{
    public delegate bool StudentPredicateDelegate(Student student);
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public static bool IsAdult(Student student)
        {
            return student.Age >= 18;
        }
        public static bool IsNameStartA(Student student)
        {
            return student.FirstName.StartsWith("A");
        }
        public static bool IsLastNameBigger3(Student student)
        {
            return student.LastName.Length >= 3;
        }

    }
}
