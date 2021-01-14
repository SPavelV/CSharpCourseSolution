                using System;
using System.Collections.Generic;
using System.Linq;

namespace C_ArraysCollections
{
    class Program
    {
        static void Main(string[] args)
        {
           
        }

        static void MultidimArray()
        {
            // 1 2 3 4
            // 1 2 3

            // 1 2 3
            // 4 5 6

            int[,] r1 = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
            int[,] r2 = { { 1, 2, 3 }, { 4, 5, 6 } };

            for (int i = 0; i < r2.GetLength(0); i++)
            {
                for (int j = 0; j < r2.GetLength(1); j++)
                {
                    Console.Write($"{r2[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }

        static void StackQueue()
        {
            var queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);

            Console.WriteLine($"Should print out 1: {queue.Peek()}");

            queue.Dequeue();

            Console.WriteLine($"Should print out 2: {queue.Peek()}");

            Console.WriteLine("Iterate over queue.");
            foreach (var cur in queue)
            {
                Console.WriteLine(cur);
            }

            Console.ReadLine();

            var stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);

            Console.WriteLine($"Should print out 4: {stack.Peek()}");

            stack.Pop();

            Console.WriteLine($"Should print out 3: {stack.Peek()}");

            Console.WriteLine("Iterate over the stack.");
            foreach (var cur in stack)
            {
                Console.WriteLine(cur);
            }
        }

        static void Dictionary()
        {
            var people = new Dictionary<int, string>();

            people.Add(1, "Jonh");
            people.Add(2, "Bob");
            people.Add(3, "Alice");

            people = new Dictionary<int, string>()
            {
                {1, "Jonh" },
                {2, "Alice" },
                {3, "Bob" }
            };

            string name = people[1];
            Console.WriteLine(name);

            Console.WriteLine("Iterating over keys");
            Dictionary<int, string>.KeyCollection keys = people.Keys;
            foreach (var item in keys)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Iterating over values");
            Dictionary<int, string>.ValueCollection values = people.Values;

            foreach (var item in values)
            {
                Console.WriteLine(item);
            }

            foreach (var pair in people)
            {
                Console.WriteLine($"Key:{pair.Key}. Value:{pair.Value}");
            }
            Console.WriteLine();

            Console.WriteLine($"Count={people.Count}");

            bool containsKey = people.ContainsKey(2);

            bool containsValue = people.ContainsValue("John");

            Console.WriteLine($"Contains key:{containsKey}. Contains value:{containsValue}");

            people.Remove(1);

            if (people.TryAdd(2, "Elias"))
            {
                Console.WriteLine("Added succesfully");
            }
            else
            {
                Console.WriteLine("Failed to add using key 2");
            }

            if (people.TryGetValue(2, out string val))
            {
                Console.WriteLine($"Key 2, Val={val}");
            }
            else
            {
                Console.WriteLine("Failed to get");
            }

            people.Clear();
        }

        static void ListDemo()
        {
            var intList = new List<int>() { 1, 4, 2, 7, 5, 9, 12 };
            intList.Add(7);

            int[] intArray = { 1, 2, 3 };
            intList.AddRange(intArray);

            if (intList.Remove(1)) // first occurence
            {
                // do
            }
            else { }

            intList.RemoveAt(0);

            intList.Reverse();

            bool contains = intList.Contains(3);

            int min = intList.Min();
            int max = intList.Max();

            Console.WriteLine($"Min={min}. Max={max}");

            int indexOf = intList.IndexOf(2);
            int lastIndexOf = intList.LastIndexOf(2);

            Console.WriteLine($"IndexOf2={indexOf}. LastIndexOf2={lastIndexOf}");

            for (int i = 0; i < intList.Count; i++)
            {
                Console.Write($"{intList[i]} ");
            }
            Console.WriteLine();

            foreach (int item in intList)
            {
                Console.Write($"{item} ");
            }
            Console.ReadLine();
        }

        static void ArrayType()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int index = Array.BinarySearch(numbers, 7);
            Console.WriteLine(index);

            int[] copy = new int[10];
            Array.Copy(numbers, copy, numbers.Length);

            int[] anotherCopy = new int[10];
            copy.CopyTo(anotherCopy, 0);

            Array.Reverse(copy);
            foreach (var c in copy)
            {
                Console.WriteLine(c);
            }

            Array.Sort(copy);
            foreach (var c in copy)
            {
                Console.WriteLine(c);
            }

            Array.Clear(copy, 0, copy.Length);


            int[] a1;
            a1 = new int[5];

            int[] a2 = new int[5];

            int[] a3 = new int[5] { 1, 3, -2, 5, 10 };

            int[] a4 = { 1, 3, 2, 4, 5 };

            Array myArray = new int[5];

            Array myArray2 = Array.CreateInstance(typeof(int), 4);
            myArray2.SetValue(12, 0);

            Console.WriteLine(myArray2.GetValue(0));
        }
    }
}
