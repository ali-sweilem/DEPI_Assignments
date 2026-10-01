using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject.Models
{
    public class QuestionList<T> : List<T> where T : Question
    {
        private string FilePath { get; set; }

        public QuestionList(string filePath)
        {
            FilePath = filePath;
        }

        public new void Add(T question)
        {
            base.Add(question);

            using StreamWriter writer =
                new StreamWriter(FilePath, true);

            writer.WriteLine(question.ToString());
        }
    }
}
