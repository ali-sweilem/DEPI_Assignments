using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject.Models
{
    public class AnswerList : List<Answer>, ICloneable
    {
        public object Clone()
        {
            AnswerList copy = new AnswerList();

            foreach (Answer answer in this)
            {
                copy.Add((Answer)answer.Clone());
            }

            return copy;
        }
    }
}
