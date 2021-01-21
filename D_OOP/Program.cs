using System;

namespace D_OOP
{
   class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();

            if(calc.TryDivide(10, 0, out double result))
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Failed to divide");
            }
            Console.ReadLine();


            Console.WriteLine("Enter a number, please.");

            string line = Console.ReadLine();

            bool wasParsed = int.TryParse(line, out int number);
            if (wasParsed)
            {
                Console.WriteLine(number);
            }
            else
            {
                Console.WriteLine("Failed to parse");
            }
        }

    }
}
