using System;
using System.Collections.Generic;

namespace D_OOP
{
   class Program
    {

        static void Main(string[] args)
        {
            //Shape shape = new Shape();

            Shape[] shapes = new Shape[2];
            shapes[0] = new Triangle(10, 20, 30);
            shapes[1] = new Rectangle(5, 10);

            foreach(Shape shape in shapes)
            {
                shape.Draw();
                Console.WriteLine(shape.Perimeter());
            }

            Console.ReadLine();
        }

        static void BoxingUnboxing()
        {
            //int x = 1;
            //object obj = x;

            //int y = (int)obj;

            double pi = 3.14;
            object obj1 = pi;

            double number = (int)(double)obj1;
            Console.WriteLine(number);
        }

        static void Do(object obj)
        {
            bool isPointRef = obj is PointRef;
            if (isPointRef)
            {
                PointRef pr = (PointRef)obj;
                Console.WriteLine(pr.X);
            }
            else
            {
                // do smth.
            }

            PointRef pr1 = obj as PointRef;
            if(pr1 != null)
            {
                Console.WriteLine(pr1.X);
            }
            else
            {
                // do smth.
            }
        }

        static void NullableValTypesDemo()
        {
            PointVal? pv = null;
            if (pv.HasValue)
            {
                PointVal pv2 = pv.Value;
                Console.WriteLine(pv.Value.X);
                Console.WriteLine(pv2.X);
            }
            else
            {

            }

            PointVal pv3 = pv.GetValueOrDefault();

            PointRef c = null;
            Console.WriteLine(c.X); // NullReferenceExcep
        }

        static void PassByRefDemo()
        {
            int a = 1;
            int b = 2;

            Swap(ref a, ref b);
            Console.WriteLine($"a={a}, b={b}");

            Console.ReadLine();

            var list = new List<int>();

            AddNumbers(list);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

        static void Swap(ref int a, ref int b)
        {
            Console.WriteLine($"Original a={a}, b={b}");

            int tmp = a;
            a = b;
            b = tmp;

            Console.WriteLine($"Swapped a={a}, b={b}");
        }

        static void AddNumbers(List<int> numbers)
        {
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
        }

    }
}
