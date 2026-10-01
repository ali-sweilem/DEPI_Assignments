using MiniProject.Exams;
using MiniProject.Models;
using System;

namespace MiniProject
{
    internal class Program
    {
        static void Main()
        {
            Subject sub = new Subject("OOP");

            var qList1 = new QuestionList<Question>("practice.txt");
            var qList2 = new QuestionList<Question>("final.txt");

            qList1.Add(new TrueFalseQuestion("Q1", "C# is an OOP language?", 5, true));
            var ans = new AnswerList{
                new Answer("Encapsulation",true),
                new Answer("Banana",false),
                new Answer("Inheritance",true)
            };
            qList1.Add(new ChooseAllQuestion("Q2", "Select OOP pillars", 10, ans));

            qList2.Add(new TrueFalseQuestion("Q1", "CLR is runtime?", 5, true));
            var ans2 = new AnswerList{
                new Answer("int",true),
                new Answer("car",false)
            };
            qList2.Add(new ChooseOneQuestion("Q2", "Select data type", 5, ans2));

            Student s1 = new Student("Ali");
            Student s2 = new Student("Mona");

            PracticeExam pe = new PracticeExam(30, qList1, sub);
            FinalExam fe = new FinalExam(60, qList2, sub);

            pe.ExamStarted += s1.OnExamStarted;
            pe.ExamStarted += s2.OnExamStarted;
            fe.ExamStarted += s1.OnExamStarted;
            fe.ExamStarted += s2.OnExamStarted;

            int choice;

            while (true)
            {
                Console.WriteLine("1-Practice 2-Final");
                string input = Console.ReadLine();

                if (int.TryParse(input, out choice) && (choice == 1 || choice == 2))
                    break;

                Console.WriteLine("Invalid choice. Please enter 1 or 2.");
            }

            if (choice == 1)
                pe.ShowExam();
            else
                fe.ShowExam();
        }
    }
}
