using System;
using System.Collections.Generic;
using System.Text;

namespace D_OOP
{
    public static class Calculator
    {
        public static double Avarage(int[] numbers)
        {
            double sum = 0;

            foreach (var n in numbers)
            {
                sum += n;
            }

            return sum / numbers.Length;
        }

        public static double Avarage2(params int[] numbers)
        {
            double sum = 0;

            foreach (var n in numbers)
            {
                sum += n;
            }

            return sum / numbers.Length;
        }

        public static double CalcTriangleSquare(double ab, double bc, double ca)
        {
            double semyPerimeter = (ab + bc + ca) / 2;
            return Math.Sqrt(semyPerimeter * (semyPerimeter - ab) * (semyPerimeter - bc) * (semyPerimeter - ca));
        }

        public static double CalcTriangleSquare(double b, double h)
        {
            return 0.5 * b * h;
        }

        public static double CalcTriangleSquare(double a, double b, int alpha)
        {
            double rads = alpha * Math.PI / 180;
            return 0.5 * a * b * Math.Sin(rads);
        }
    }
}
