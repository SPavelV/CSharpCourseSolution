using System;

namespace B_ControlFlow
{
    class Program
    {
        static void Main(string[] args)
        {
  
        }

        static void Avarage()
        {
            int[] numbers = new int[10];

            int inputCount = 0;

            while (inputCount < 10)
            {
                int number = int.Parse(Console.ReadLine());
                numbers[inputCount] = number;

                inputCount++;

                if (number == 0)
                    break;

            }

            int sum = 0;
            int count = 0;

            foreach (int n in numbers)
            {
                if (n > 0 && n % 3 == 0)
                {
                    sum += n;
                    count++;
                }
            }

            double avarage = (double)sum / count;
            Console.WriteLine($"Avarage: {avarage}");
        }

        static void Fibonacci()
        {
            Console.WriteLine("Введите количество чисел фибоначчи");

            int n = int.Parse(Console.ReadLine());

            int[] fibonacci = new int[n];

            int a0 = 0;
            int a1 = 1;

            fibonacci[0] = a0;
            fibonacci[1] = a1;

            for (int i = 2; i < n; i++)
            {
                int a = a0 + a1;
                fibonacci[i] = a;

                a0 = a1;
                a1 = a;
            }

            Console.Write("Фибоначчи: ");

            foreach (int cur in fibonacci)
            {
                Console.Write($"{cur} ");
            }

            Console.ReadLine();
        }

        static void SwithcCase()
        {
            int month = int.Parse(Console.ReadLine());
            string season = string.Empty;

            switch (month)
            {
                case 1:
                case 2:
                case 12:
                    season = "Winter";
                    break;
                case 3:
                case 4:
                case 5:
                    season = "Spring";
                    break;
                case 6:
                case 7:
                case 8:
                    season = "Summer";
                    break;
                case 9:
                case 10:
                case 11:
                    season = "Autumn";
                    break;
                default:
                    throw new ArgumentException("Unexpected number of mounth");
            }

            Console.WriteLine(season);

            Console.ReadLine();

            int weddingYears = int.Parse(Console.ReadLine());

            string name = string.Empty;

            switch (weddingYears)
            {
                case 5:
                    name = "Деревянная свадьба";
                    break;
                case 10:
                    name = "Оловянная свадьба";
                    break;
                case 15:
                    name = "Хрустальная свадьба";
                    break;
                case 20:
                    name = "Форфоровая свадьба";
                    break;
                case 25:
                    name = "Серебряная свадьба";
                    break;
                case 30:
                    name = "Жемчужная свадьба";
                    break;
                default:
                    name = "Не знаем такого юбелея";
                    break;
            }
            Console.WriteLine(name);
        }

        static void BreakContinue()
        {
            int[] numbers = { 0, 3, 1, 5, 4, 6, 7, 8, 9 };

            foreach (int n in numbers)
            {
                //if(n%2 == 0)
                //{
                //    Console.WriteLine(n);
                //}

                if (n % 2 != 0)
                {
                    continue;
                }
                Console.WriteLine(n);
            }

            Console.ReadLine();

            char[] letters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j' };

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"Number={numbers[i]}");

                for (int j = 0; j < letters.Length; j++)
                {
                    if (numbers[i] == j) break;
                    Console.Write($" {letters[j]} ");
                }
                Console.WriteLine();
            }

            Console.ReadLine();

            int[] numbers2 = { 1, -2, 4, -7, 5, 3, 2, -1, -3, 2, 7, -1, -3, 1, 7 };

            int counter = 0;
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (counter == 3)
                {
                    break;
                }
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    int atI = numbers2[i];
                    int atJ = numbers2[j];

                    if (atI + atJ == 0)
                    {
                        Console.WriteLine($"Pair({atI};{atJ}). Indexes ({i};{j})");
                        counter++;
                    }

                    if (counter == 3)
                    {
                        break;
                    }
                }
            }
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
