using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema15
{
    public enum Specialization
    {
        Informatics,
        Letters,
        Constructions
    }

    public class Student
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public int Age { get; set; }
        public Specialization Specialization { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}, Age: {Age}, Specialization: {Specialization}";
        }
    }
    }
