using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InlämningV44
{
    internal class Student
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public string City { get; set; } = "";

        public Student(string firstName, string lastName, string city)
        {
            FirstName = firstName;
            LastName = lastName;
            City = city;
        }

        public Student()
        {
            
        }

        public override string ToString()
        {
            return $"Student ID: {StudentId} \n\tNamn: {FirstName} {LastName} \n\tStad: {City}\n";
        }
    }
}
