using MiniProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject.Exams
{
    public abstract class Exam<T> : ICloneable, IComparable<Exam<T>> where T : Question
    {
        public int Time { get; set; }

        public QuestionList<T> Questions { get; set; }

        public Dictionary<T, List<int>> QuestionAnswers
        {
            get;
            set;
        }

        public Subject Subject { get; set; }

        public ExamMode Mode { get; set; }

        public event EventHandler? ExamStarted;

        protected Exam( int time, QuestionList<T> questions, Subject subject)
        {
            Time = time;
            Questions = questions;
            Subject = subject;

            QuestionAnswers =
                new Dictionary<T, List<int>>();

            Mode = ExamMode.Queued;
        }

        public void Start()
        {
            Mode = ExamMode.Starting;

            ExamStarted?.Invoke(
                this,
                EventArgs.Empty);
        }

        protected void CollectAnswer(T question)
        {
            while (true)
            {
                Console.Write(
                    "Enter answer(s), separated by comma: ");

                string? input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                    continue;

                string[] values = input.Split(',');

                List<int> answers = new List<int>();

                bool valid = true;

                foreach (string value in values)
                {
                    if (!int.TryParse( value.Trim(), out int answerNumber))
                    {
                        valid = false;
                        break;
                    }

                    answerNumber--;

                    if (answerNumber < 0 || answerNumber >= question.Answers.Count)
                    {
                        valid = false;
                        break;
                    }

                    answers.Add(answerNumber);
                }

                if (valid)
                {
                    QuestionAnswers[question] =
                        answers;

                    break;
                }

                Console.WriteLine(
                    "Invalid answer. Try again.");
            }
        }

        public abstract void ShowExam();

        public object Clone()
        {
            Exam<T> clone = (Exam<T>)MemberwiseClone();

            clone.Questions = new QuestionList<T>( "CloneQuestions.txt");

            foreach (T question in Questions)
            {
                clone.Questions.Add((T)question.Clone());
            }

            clone.QuestionAnswers = new Dictionary<T, List<int>>();

            return clone;
        }

        public int CompareTo(Exam<T>? other)
        {
            if (other == null)
                return 1;

            return Time.CompareTo(other.Time);
        }

        public override string ToString()
        {
            return $"{Subject} - {Time} minutes";
        }

        public override bool Equals(object? obj)
        {
            if (obj is not Exam<T> other)
                return false;

            return Subject.Equals(other.Subject) &&
                    Time == other.Time;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(
                Subject,
                Time);
        }
    }
}
