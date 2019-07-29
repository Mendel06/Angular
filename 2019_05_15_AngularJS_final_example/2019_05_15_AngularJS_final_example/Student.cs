using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _2019_05_15_AngularJS_final_example
{
    public class Student
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        
        public Student(int studentId, string firstName, string lastName)
        {
            StudentId = studentId;
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
