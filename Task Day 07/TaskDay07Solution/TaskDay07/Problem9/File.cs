using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskDay07.Problem9
{
    internal class File : IReadable, IWritable
    {
        public void Read()
        {
            Console.WriteLine("Reading from file...");
        }
        public void Write()
        {
            Console.WriteLine("Write from file...");
        }


    }
}
