using System;

namespace D_OOP
{
   class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();

            double avg = calc.Avarage(new int[] { 1, 2, 3, 4 });
            double avg2 = calc.Avarage2(1, 2, 3, 4 );
            Console.WriteLine(avg2);

        }

        static void TriangleSquare()
        {
            Calculator calc = new Calculator();
            double square1 = calc.CalcTriangleSquare(10, 20);
            double square2 = calc.CalcTriangleSquare(10, 20, 30);
            double square3 = calc.CalcTriangleSquare(10, 20, 50);
            Console.WriteLine($"Square3={square3}");
        }
    }
}
