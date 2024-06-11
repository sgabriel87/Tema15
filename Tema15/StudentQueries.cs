using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema15
{
    public static class StudentQueries
    {
        public static Student? GetOldestStudentInInformatics(List<Student> students)
        {
            if (students == null || students.Count == 0)
            {
                return null;
            }

            return students.Where(s => s.Specialization == Specialization.Informatics)
                           .OrderByDescending(s => s.Age)
                           .FirstOrDefault();
        }
        public static Student? GetYoungestStudent(List<Student> students)
        {
            if (students == null || students.Count == 0)
            {
                return null;
            }

            return students.OrderBy(s => s.Age).FirstOrDefault();
        }
        public static Student? GetYoungestStudentAggregate(List<Student> students)
        {
            if (students == null || students.Count == 0)
            {
                return null;
            }

            return students.Aggregate((s1, s2) => s1.Age < s2.Age ? s1 : s2);
        }
        public static IEnumerable<Student> GetStudentsInLettersOrderedByAge(List<Student> students)
        {
            if (students == null || students.Count == 0)
            {
                return Enumerable.Empty<Student>();
            }

            return students.Where(s => s.Specialization == Specialization.Letters)
                           .OrderBy(s => s.Age);
        }
        public static Student? GetFirstStudentInConstructionsOver20(List<Student> students)
        {
            if (students == null || students.Count == 0)
            {
                return null;
            }

            return students.Where(s => s.Specialization == Specialization.Constructions && s.Age > 20)
                           .FirstOrDefault();
        }
        public static IEnumerable<Student> GetStudentsWithAverageAge(List<Student> students)
        {
            if (students == null || students.Count == 0)
            {
                return [];
            }

            var averageAge = students.Average(s => s.Age);
            return students.Where(s => s.Age == averageAge);
        }
        public static IEnumerable<Student> GetStudents18To35Ordered(List<Student> students)
        {
            if (students == null || students.Count == 0)
            {
                return [];
            }

            return students.Where(s => s.Age >= 18 && s.Age <= 35)
                           .OrderByDescending(s => s.Age)
                           .ThenBy(s => s.LastName)
                           .ThenBy(s => s.FirstName);
        }
        public static Student? GetLastStudent(List<Student> students)
        {
            if (students == null || students.Count == 0)
            {
                return null;
            }

            return students.LastOrDefault();
        }
        public static string CheckForMinors(List<Student> students)
        {
            if (students == null || students.Count == 0)
            {
                return "There are no minors";
            }

            var hasMinors = students.Any(s => s.Age < 18);
            return hasMinors ? "There are minors" : "There are no minors";
        }
        public static IEnumerable<IGrouping<int, Student>> GetStudentsGroupedByAge(List<Student> students)
        {
            if (students == null || students.Count == 0)
            {
                return [];
            }

            return students.GroupBy(s => s.Age);
        }
    }
}
