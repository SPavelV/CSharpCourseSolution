﻿using System;

namespace D_OOP
{
   class Program
    {
        static void Main(string[] args)
        {

            Calculator calc = new Calculator();
            double square1 = calc.CalcTriangleSquare(10, 20);
            double square2 = calc.CalcTriangleSquare(10, 20, 30);
            double square3 = calc.CalcTriangleSquare(10, 20, 50);
            Console.WriteLine($"Square3={square3}");
        }

        static void TriangleSquare()
        {
            Calculator calc = new Calculator();
            double square1 = calc.CalcTriangleSquare(10, 20);
            double square2 = calc.CalcTriangleSquare(10, 20, 30);

            Console.WriteLine($"Square1={square1}. Square2={square2}");
        }
    }
}
