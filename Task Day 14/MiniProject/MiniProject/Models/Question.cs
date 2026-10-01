using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject.Models
{
    public abstract class Question : ICloneable, IComparable<Question>
    {
        public string Header { get; set; }
        public string Body { get; set; }
        public int Marks { get; set; }

        public AnswerList Answers { get; set; }

        protected Question() : this("", "", 0, new AnswerList())
        {
        }

        protected Question(string header, string body, int marks, AnswerList answers)
        {
            Header = header;
            Body = body;
            Marks = marks;
            Answers = answers;
        }

        public abstract void Show();
        public virtual object Clone()
        {
            Question clone =
                (Question)MemberwiseClone();

            clone.Answers =
                (AnswerList)Answers.Clone();

            return clone;
        }
        public int CompareTo(Question other)
        {
            if (other == null)
                return 1;

            return Marks.CompareTo(other.Marks);
        }
        public override string ToString()
        {
            return $"{Header} - {Body} ({Marks})";
        }

        public override bool Equals(object? obj)
        {
            if (obj is not Question other)
                return false;

            return Header == other.Header &&
                   Body == other.Body;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Header, Body);
        }
    }
}
