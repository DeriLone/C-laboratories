using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11_2
{
    public static class Extension
    {
        public static List<Student> FindStudent(this List<Student> students, StudentPredicateDelegate studentPredicate)
        {

            var newStudents = new List<Student>();

            foreach (var student in students)
            {
                if (studentPredicate(student))
                {
                    newStudents.Add(student);
                }
            }

            return newStudents;
        }
    }
}