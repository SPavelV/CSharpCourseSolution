using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Timers;

namespace G_Delegation
{
    public static class LinqExtensions
    {
        public static void ForEach<T>(this IEnumerable<T> source, Action<T> action)
        {
            if (source == null)
                throw new ArgumentNullException();

            foreach (var item in source)
            {
                action(item);
            }
        }
    }
    class Program
    {
        static Car car;
        static void Main(string[] args)
        {
            DisplayLargestFilesWithLinq(@"E:\games");
            DisplayLargestFilesWithoutLinq(@"E:\games");
            Console.ReadLine();
        }

        private static void DisplayLargestFilesWithLinq(string pathToDir)
        {
            new DirectoryInfo(pathToDir)
                .GetFiles()
                .OrderByDescending(file => file.Length)
                .Take(5)
                .ForEach(file => Console.WriteLine($"{file.Name} weights {file.Length}"));

            //IEnumerable<FileInfo> orderedFiles = new DirectoryInfo(pathToDir)
            //    .GetFiles()
            //    .OrderBy(file => file.Length)
            //    .Take(5);

            //foreach(var file in orderedFiles)
            //{
            //    Console.WriteLine($"{file.Name} weights {file.Length}");
            //}
        }

        //static long KeySelector(FileInfo file)
        //{
        //    return file.Length;
        //}

        private static void DisplayLargestFilesWithoutLinq(string pathToDir)
        {
            var dirInfo = new DirectoryInfo(pathToDir);
            FileInfo[] files = dirInfo.GetFiles();

            Array.Sort(files, FilesComparison);

            for (int i = 0; i < 5; i++)
            {
                FileInfo file = files[i];
                Console.WriteLine($"{file.Name} weights {file.Length}");
            }
        }

        private static int FilesComparison(FileInfo x, FileInfo y)
        {
            if (x.Length == y.Length) return 0;
            if (x.Length > y.Length) return -1;
            return 1;
        }

        private static void EventDemo()
        {
            Timer timer = new Timer();
            timer.Elapsed += Timer_Elapsed;

            timer.Interval = 5000;
            timer.Start();

            Console.ReadLine();

            car = new Car();
            car.TooFastDriving += HandleOnTooFast;
            car.TooFastDriving += HandleOnTooFast;

            car.TooFastDriving -= HandleOnTooFast;

            car.Start();

            for (int i = 0; i < 10; i++)
            {
                car.Accelerate();
            }

            Console.ReadLine();
        }

        private static void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            //var timer = (Timer)sender;
            Console.WriteLine("Handler Timer Elapsed Event");
        }

        private static void HandleOnTooFast(int speed)
        {
            Console.WriteLine($"Oh, I got it, calling stop! Current speed={speed}");
            car.Stop();
        }
    }

    public class Car
    {
        int speed = 0;

        public event Action<int> TooFastDriving;
        //public event Func<int, string> TooFastDriving;

        //public delegate void TooFast(int currentSpeed);

        //private TooFast tooFast;

        public void Start()
        {
            speed = 10;
        }

        public void Accelerate()
        {
            speed += 10;

            if (speed > 80)
            {
                if (TooFastDriving != null)
                    TooFastDriving(speed);
            }
        }

        public void Stop()
        {
            speed = 0;
        }

        //public void RegisterOnTooFast(TooFast tooFast)
        //{
        //    this.tooFast += tooFast;
        //}

        //public void UnregisterOnTooFast(TooFast tooFast)
        //{
        //    this.tooFast -= tooFast;
        //}
    }
}
