﻿using System;
using System.Collections.Generic;
using System.Text;

namespace D_OOP
{
    public class Calculator
    {
        public bool TryDivide(double divisible, double divisor, out double result)
        {
            result = 0;
            if(divisor == 0)
            {
                return false;
            }
            result = divisible / divisor;
            return true;
        }

        public double Avarage(int[] numbers)
        {
            double sum = 0;

            foreach (var n in numbers)
            {
                sum += n;
            }

            return sum / numbers.Length;
        }

        public double Avarage2(params int[] numbers)
        {
            double sum = 0;

            foreach (var n in numbers)
            {
                sum += n;
            }

            return sum / numbers.Length;
        }

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
