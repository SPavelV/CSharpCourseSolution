using System;

namespace B_ControlFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        static void WhileDoWhile()
        {
            int age = 30;

            while (age < 18)
            {
                Console.WriteLine("First while loop");
                Console.WriteLine("What is your age?");
                age = int.Parse(Console.ReadLine());
            }


            do
            {
                Console.WriteLine("Do\\While");
                Console.WriteLine("What is your age?");
                age = int.Parse(Console.ReadLine());

            } while (age < 18);
            Console.WriteLine("Good!");

            int[] numbers = { 1, 2, 3, 4, 5 };
            int i = 0;
            while (i < numbers.Length)
            {
                Console.Write(numbers[i]);
                i++;
            }
        }

        static void NestedFor()
        {
            int[] numbers = { 1, -2, 4, -7, 5, 3, 2, -1, -3, 2, 7, -1, -3, 1, 7 };
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    int atI = numbers[i];
                    int atJ = numbers[j];

                    if (atI + atJ == 0)
                    {
                        Console.WriteLine($"Pair({atI};{atJ}). Indexes ({i};{j})");
                    }
                }
            }

            Console.WriteLine();

            for (int i = 0; i < numbers.Length - 2; i++)
            {
                for (int j = i + 1; j < numbers.Length - 1; j++)
                {
                    for (int k = j + 1; k < numbers.Length; k++)
                    {
                        int atI = numbers[i];
                        int atJ = numbers[j];
                        int atK = numbers[k];

                        if (atI + atJ + atK == 0)
                        {
                            Console.WriteLine($"Triplets({atI};{atJ};{atK}). Indexes ({i};{j};{k})");
                        }
                    }

                }
            }
        }

        static void ForForeach()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }

            Console.WriteLine();

            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                Console.Write(numbers[i] + " ");
            }

            Console.WriteLine();

            for (int j = 0; j < numbers.Length; j++)
            {
                if (numbers[j] % 2 == 0)
                {
                    Console.Write(numbers[j] + " ");
                }
            }

            Console.WriteLine();

            foreach (int val in numbers)
            {
                Console.Write(val + " ");
            }

        }

        static void GetMax()
        {
            Console.WriteLine("Введите целое чесло:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите еще целое чесло:");
            int num2 = int.Parse(Console.ReadLine());

            int max = num1 > num2 ? num1 : num2;

            Console.WriteLine($"Максимальное число: {max}");
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
