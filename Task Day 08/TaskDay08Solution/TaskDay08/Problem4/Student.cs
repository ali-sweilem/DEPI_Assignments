using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskDay08.Problem4
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Grade { get; set; }

        public Student(int id, string name, double grade)
        {
            Id = id;
            Name = name;
            Grade = grade;
        }

        // Copy constructor
        public Student(Student student)
        {
            Id = student.Id;
            Name = student.Name;
            Grade = student.Grade;
        }

        public void Display()
        {
            Console.WriteLine($"Id: {Id}, Name: {Name}, Grade: {Grade}");
        }
    }
}
