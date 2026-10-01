using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject.Models
{
    internal class ChooseAllQuestion : Question
    {
        public ChooseAllQuestion() : this("", "", 0, new AnswerList())
        {
        }

        public ChooseAllQuestion( string header, string body, int marks, AnswerList answers)
        : base(header, body, marks, answers)
        {
        }

        public override void Show()
        {
            Console.WriteLine(Header);
            Console.WriteLine(Body);

            for (int i = 0; i < Answers.Count; i++)
            {
                Console.WriteLine($"{i + 1}- {Answers[i]}");
            }
        }
    }
}
