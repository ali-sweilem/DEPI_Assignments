using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject.Models
{
    public class Answer : ICloneable, IComparable<Answer>
    {
        public string Text { get; set; }

        public bool IsCorrect { get; set; }

        public Answer() : this("", false)
        {
        }
        public Answer(string text, bool isCorrect)
        {
            Text = text;
            IsCorrect = isCorrect;
        }

        public object Clone()
        {
            return new Answer(Text, IsCorrect);
        }

        public int CompareTo(Answer? other)
        {
            if (other == null)
                return 1;

            return Text.CompareTo(other.Text);
        }

        public override string ToString()
        {
            return Text;
        }
    }
}
