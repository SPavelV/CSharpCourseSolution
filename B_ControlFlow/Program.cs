using System;

namespace B_ControlFlow
{
    class Program
    {
        static void Main(string[] args)
        {
          
        }

        static void IfElse()
        {
            Console.WriteLine("Введите возраст:");
            double age = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите ваш вес(кг):");
            double weight = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите ваш рост(м):");
            double height = double.Parse(Console.ReadLine());

            double bodyMassIndex = weight / (height * height);

            bool isTooLow = bodyMassIndex <= 18.5;
            bool isNormal = bodyMassIndex > 18.5 && bodyMassIndex < 25;
            bool isAboveNormal = bodyMassIndex >= 25 && bodyMassIndex <= 30;
            bool isTooFat = bodyMassIndex > 30;

            bool isFat = isAboveNormal || isTooFat;

            if (isFat)
            {
                Console.WriteLine("Лучше сбросить вес.");
            }
            else
            {
                Console.WriteLine("Ты в хорошей форме.");
            }

            // if(isFat == false)
            if (!isFat)
            {
                Console.WriteLine("Ты не в плохой форме!");
            }

            if (isTooLow)
            {
                Console.WriteLine("Недостаточно веса.");
            }
            else if (isNormal)
            {
                Console.WriteLine("Ты OK");
            }
            else if (isAboveNormal)
            {
                Console.WriteLine("Буть осторожен");
            }
            else
            {
                Console.WriteLine("Тебе нужно сбросить лишний вес.");
            }

            if (isFat || isTooFat)
            {
                Console.WriteLine("Время сесть на диету");
            }

            // ternary operation
            string description = age > 18 ? "Ты можешь пить алкоголь" : "Ты должен быть старше";

            // the same in if-else construct
            //if(age > 18)
            //{
            //    description = "Ты можешь пить алкоголь";
            //}
            //else
            //{
            //    description = "Ты должен быть старше";
            //}
            Console.WriteLine(description);
        }
    }
}
