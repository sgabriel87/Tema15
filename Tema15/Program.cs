

using Tema15;

List<Student> students =
        [
            new Student { 
                Id = 1, 
                LastName = "Avram", 
                FirstName = "Tamara", 
                Age = 21, 
                Specialization = Specialization.Informatics
            },
            new Student { 
                Id = 2, 
                LastName = "Petru", 
                FirstName = "Sandu", 
                Age = 18, 
                Specialization = Specialization.Letters
            },
            new Student { 
                Id = 3, 
                LastName = "Dorin", 
                FirstName = "Constantin", 
                Age = 23, 
                Specialization = Specialization.Constructions 
            },
            new Student { 
                Id = 4, 
                LastName = "Lucian", 
                FirstName = "Mihail", 
                Age = 20, 
                Specialization = Specialization.Letters
            },
            new Student { 
                Id = 5, 
                LastName = "Sorina",
                FirstName = "Camelia",
                Age = 25,
                Specialization = Specialization.Informatics 
            },
            new Student {
                Id = 6, 
                LastName = "Adi", 
                FirstName = "Stefan", 
                Age = 25, 
                Specialization = Specialization.Constructions
            }
        ];

var oldestInInformatics = StudentQueries.GetOldestStudentInInformatics(students);
if (oldestInInformatics != null)
{
    Console.WriteLine("Oldest student in Informatics: " + oldestInInformatics);
}
else
{
    Console.WriteLine("No students in Informatics.");
}


var youngestStudent1 = StudentQueries.GetYoungestStudent(students);
if (youngestStudent1 != null)
{
    Console.WriteLine("Youngest student (method 1): " + youngestStudent1);
}
else
{
    Console.WriteLine("No students available.");
}

var youngestStudent2 = StudentQueries.GetYoungestStudentAggregate(students);
if (youngestStudent2 != null)
{
    Console.WriteLine("Youngest student (method 2): " + youngestStudent2);
}
else
{
    Console.WriteLine("No students available.");
}


var lettersStudents = StudentQueries.GetStudentsInLettersOrderedByAge(students);
if (lettersStudents.Any())
{
    Console.WriteLine("Students in Letters in ascending order of age:");
    foreach (var student in lettersStudents)
    {
        Console.WriteLine(student);
    }
}
else
{
    Console.WriteLine("No students in Letters.");
}


var firstOver20InConstructions = StudentQueries.GetFirstStudentInConstructionsOver20(students);
if (firstOver20InConstructions != null)
{
    Console.WriteLine("First student in Constructions over 20 years old: " + firstOver20InConstructions);
}
else
{
    Console.WriteLine("No students in Constructions over 20 years old.");
}


var studentsWithAverageAge = StudentQueries.GetStudentsWithAverageAge(students);
if (studentsWithAverageAge.Any())
{
    Console.WriteLine($"Students with age equal to the average age ({students.Average(s => s.Age)}):");
    foreach (var student in studentsWithAverageAge)
    {
        Console.WriteLine(student);
    }
}
else
{
    Console.WriteLine("No students with average age.");
}


var students18To35 = StudentQueries.GetStudents18To35Ordered(students);
if (students18To35.Any())
{
    Console.WriteLine("Students aged 18 to 35 in descending order of age, then alphabetically:");
    foreach (var student in students18To35)
    {
        Console.WriteLine(student);
    }
}
else
{
    Console.WriteLine("No students aged 18 to 35.");
}


var lastStudent = StudentQueries.GetLastStudent(students);
if (lastStudent != null)
{
    Console.WriteLine("Last student in the list: " + lastStudent);
}
else
{
    Console.WriteLine("No students in the list.");
}


Console.WriteLine(StudentQueries.CheckForMinors(students));

var studentsGroupedByAge = StudentQueries.GetStudentsGroupedByAge(students);
if (studentsGroupedByAge.Any())
{
    foreach (var group in studentsGroupedByAge)
    {
        Console.WriteLine($"Students aged {group.Key}:");
        foreach (var student in group)
        {
            Console.WriteLine(student);
        }
    }
}
else
{
    Console.WriteLine("No students available to group by age.");
}
    
