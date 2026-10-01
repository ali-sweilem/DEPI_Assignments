using MiniProject.Exams;
using MiniProject.Models;
using System;

namespace MiniProject.Exams
{
    public class FinalExam : Exam<Question>
    {
        public FinalExam( int time, QuestionList<Question> questions, Subject subject)
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

                Console.WriteLine();
            }

            Mode = ExamMode.Finished;
        }
    }
}