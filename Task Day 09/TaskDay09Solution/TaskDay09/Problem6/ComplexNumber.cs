using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskDay09.Problem6
{
    internal class ComplexNumber
    {
        public double Real { get; set; }
        public double Imaginary { get; set; }

        public ComplexNumber(double real, double imaginary)
        {
            Real = real;   
            Imaginary = imaginary;
        }

        // Operator Overloading for *
        public static ComplexNumber operator *(ComplexNumber c1, ComplexNumber c2)
        {
            double real = (c1.Real * c2.Real) - (c1.Imaginary * c2.Imaginary);
            double imaginary = (c1.Real * c2.Imaginary) + (c1.Imaginary * c2.Real);

            return new ComplexNumber(real, imaginary);
        }

        public void Display()
        {
            Console.WriteLine($"{Real} + {Imaginary}i");
        }
    }
}
