using MiniProject.Exams;
using MiniProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject.Exams
{
    public class PracticeExam : Exam<Question>
    {
        public PracticeExam( int time, QuestionList<Question> questions, Subject subject)
        : base(time, questions, subject)
        {
        }

        public override void ShowExam()
        {
            Start();

            foreach (Question question in Questions)
            {
                question.Show();

                CollectAnswer(question);
            }

            Console.WriteLine();
            Console.WriteLine("Correct Answers:");

            foreach (Question question in Questions)
            {
                foreach (Answer answer in question.Answers)
                {
                    if (answer.IsCorrect)
                    {
                        Console.WriteLine(
                            $"{question.Body} -> {answer}");
                    }
                }
            }

            Mode = ExamMode.Finished;
        }
    }
}
