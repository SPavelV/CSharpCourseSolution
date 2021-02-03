using System;

namespace D_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Complex c1 = new Complex(1, 1);
            Complex c2 = new Complex(1, 2);

            Complex result = c1.Plus(c2);

            Console.WriteLine($"Result. Real={result.Re}; Imaginary={result.Im}");
        }
    }

    public class Complex
    {
        public double Re { get; private set; }
        public double Im { get; private set; }

        public Complex(double re, double im)
        {
            Re = re;
            Im = im;
        }

        public Complex Plus(Complex number)
        {
            return new Complex(this.Re + number.Re, this.Im + number.Im); 
        }

        public Complex Minus(Complex number)
        {
            return new Complex(this.Re - number.Re, this.Im + number.Im);
        }
    }
}
