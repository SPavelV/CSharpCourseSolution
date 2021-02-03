using System;
using System.Timers;

namespace G_Delegation
{
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

            if(speed > 80)
            {
                if(TooFastDriving !=null)
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
    class Program
    {
        static Car car;
        static void Main(string[] args)
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

            for(int i = 0; i < 10; i++)
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
}
