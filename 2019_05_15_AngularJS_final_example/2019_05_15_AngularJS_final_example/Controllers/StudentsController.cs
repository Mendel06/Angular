using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _2019_05_15_AngularJS_final_example.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        public static List<Student> students = new List<Student>();

        [HttpGet("add")]
        public int Add(string firstName, string lastName)
        {
            if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName))
                return -1;
            int studentId = students.Count;
            Student student = new Student(studentId, firstName, lastName);
            students.Add(student);
            return studentId;
        }

        [HttpGet("all")]
        public List<Student> GetAllStudents()
        {
            return students;
        }

        [HttpGet("update")]
        public void Update(int studentId, string firstName, string lastName)
        {
            foreach(Student student in students)
            {
                if(student.StudentId == studentId)
                {
                    student.FirstName = firstName;
                    student.LastName = lastName;
                    return;
                }
            }
        }
    }
}