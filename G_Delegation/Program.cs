using System;

namespace G_Delegation
{
    public class Car
    {
        int speed = 0;
        public delegate void TooFast(int currentSpeed);

        private TooFast tooFast;

        public void Start()
        {
            speed = 10;
        }

        public void Accelerate()
        {
            speed += 10;

            if(speed > 80)
            {
                tooFast(speed);
            }
        }

        public void Stop()
        {
            speed = 0;
        }

        public void RegisterOnTooFast(TooFast tooFast)
        {
            this.tooFast = tooFast;
        }
    }
    class Program
    {
        static Car car;
        static void Main(string[] args)
        {
            car = new Car();
            car.RegisterOnTooFast(HandleOnTooFast);

            car.Start();

            for(int i = 0; i < 10; i++)
            {
                car.Accelerate();
            }

            Console.ReadLine();
        }

        private static void HandleOnTooFast(int speed)
        {
            Console.WriteLine($"Oh, I got it, calling stop! Current speed={speed}");
            car.Stop();
        }
    }
}
