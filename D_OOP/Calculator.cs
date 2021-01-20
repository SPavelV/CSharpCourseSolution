using System;
using System.Collections.Generic;
using System.Text;

namespace D_OOP
{
    public class Calculator
    {
        public double CalcTriangleSquare(double ab, double bc, double ca)
        {
            double semyPerimeter = (ab + bc + ca) / 2;
            return Math.Sqrt(semyPerimeter * (semyPerimeter - ab) * (semyPerimeter - bc) * (semyPerimeter - ca));
        }

        public double CalcTriangleSquare(double b, double h)
        {
            return 0.5 * b * h;
        }

        public double CalcTriangleSquare(double a, double b, int alpha)
        {
            double rads = alpha * Math.PI / 180;
            return 0.5 * a * b * Math.Sin(rads);
        }
    }
}
