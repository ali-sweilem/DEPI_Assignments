using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject.Models
{
    public class Student
    {
        public string Name { get; set; }

        public Student() : this("")
        {
        }

        public Student(string name)
        {
            Name = name;
        }

        public void OnExamStarted(object? sender, EventArgs e)
        {
            Console.WriteLine(
                $"Notification for {Name}: Exam Started");
        }
    }
}
