using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject.Models
{
    internal class TrueFalseQuestion : Question
    {   

        public TrueFalseQuestion(string header, string body, int marks, bool correctAnswer)
        : base(header, body, marks, new AnswerList{ new Answer("True", correctAnswer), new Answer("False", !correctAnswer) })
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
