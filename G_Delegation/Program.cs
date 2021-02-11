using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Timers;

namespace G_Delegation
{

    class Program
    {

        static void Main(string[] args)
        {
            RemoveAllDemo();
        }

        static void RemoveAllDemo()
        {
            var list = new List<int> { 0, 1, 2, 3, 4, 5 };
            list.RemoveAll(x => x <= 3);

            foreach(var item in list)
            {
                Console.WriteLine(item);
            }
        }

        static void RemoveInFor()
        {
            var list = new List<int> { 0, 1, 2, 3, 4, 5 };
            for(int i = 0; i < list.Count; i++)
            {
                var item = list[i];
                if(item <= 3)
                {
                    list.Remove(item);
                    i--;
                }
            }

            Console.WriteLine(list.Count == 2);
        }

        static void RemoveInForBackwards()
        {
            var list = new List<int> { 0, 1, 2, 3, 4, 5 };
            for (int i = list.Count - 1; i >=0 ; i--)
            {
                var item = list[i];
                if (item <= 3)
                {
                    list.Remove(item);
                }
            }

            Console.WriteLine(list.Count == 2);
        }

        static void RemoveInForeach()
        {
            var list = new List<int> { 0, 1, 2, 3, 4, 5 };
            foreach(var item in list)
            {
                if(item % 2 == 0)
                {
                    list.Remove(item);
                }
                Console.WriteLine(list.Count);
            }

            List<int>.Enumerator ennumerator = list.GetEnumerator();
            try
            {
                while (ennumerator.MoveNext())
                {
                    int item = ennumerator.Current;
                }
            }
            finally
            {
                ennumerator.Dispose();
            }
        } 

        static void DeferredExecutionDemo()
        {
            var list = new List<int> { 1, 2, 3 };
            //var query = list.Where(c => c >= 2);
            var query = list.Where(c => c >= 2).ToList();
            list.Remove(3);

            //Console.WriteLine(query.Count());
            foreach (var item in query)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }

        static void LinqDemo(string file)
        {
            IEnumerable<ChessPlayer> list = File.ReadAllLines(file)
                                        .Skip(1)
                                        .Select(x => ChessPlayer.ParseFideCsv(x))
                                        // old-style anonymus method syntax:
                                        //.Where(delegate(ChessPlayer player) { return player.BirthYear > 1988; })
                                        .Where(player => player.BirthYear > 1988)
                                        .OrderByDescending(player => player.Rating)
                                        .ThenBy(player => player.Country)
                                        .Take(10)
                                        .ToList();

            // SQL-like syntax:
            //IEnumerable<ChessPlayer> list2 = File.ReadAllLines(file)
            //                                .Skip(1)
            //                                .Select(ChessPlayer.ParseFideCsv);

            //var filtered = from player in list2
            //               where player.BirthYear > 1988
            //               orderby player.Rating descending
            //               select player;

            foreach(var player in list)
            {
                Console.WriteLine(player);
            }

            foreach(var player in list)
            {
                Console.WriteLine(player);
            }

            Console.WriteLine($"The lowest rating int TOP 10: {list.Min(x => x.Rating)}");
            Console.WriteLine($"The highest rating int TOP 10: {list.Max(x => x.Rating)}");
            Console.WriteLine($"The average rating int TOP 10: {list.Average(x => x.Rating)}");

            Console.WriteLine(list.First());
            Console.WriteLine(list.Last());

            Console.WriteLine(list.First( player => player.Country == "USA"));
            Console.WriteLine(list.Last( player => player.Country == "USA"));

            var firstFromBra = list.FirstOrDefault(player => player.Country == "Bra");
            if (firstFromBra != null)
            {
                Console.WriteLine(firstFromBra.LastName);
            }

            var lastFromBra = list.LastOrDefault(player => player.Country == "Bra");

            Console.WriteLine(list.Single(player=>player.Country == "Bra"));
            Console.WriteLine(list.SingleOrDefault(player=>player.Country == "Bra"));

            Console.WriteLine(list.SingleOrDefault(player=>player.Country == "USA"));

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
        static Car car;
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
