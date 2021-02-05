using System;

namespace D_Practice
{
    public enum GuessingPlayer
    {
        Human,
        Machine
    }

    class Program
    {
        static void Main(string[] args)
        {
            GuessNumber game = new GuessNumber(GuessingPlayer.Human);

            game.Start();
            Console.ReadLine();
        }
    }

    public class GuessNumber
    {
        private const int maxHiddenValue = 100;
        private int qtyAttempt = 5;
        private readonly GuessingPlayer guessingPlayer;
        public int HiddenNumber { get; private set; }

        public GuessNumber(GuessingPlayer guessingPlayer)
        {
            this.guessingPlayer = guessingPlayer;
        }

        public void Start()
        {
            if(guessingPlayer == GuessingPlayer.Human)
            {
                HumanGuesses();
            }
            else
            {
                MachineGuesses();
            }
            Console.ReadLine();
        }

        private void MachineGuesses()
        {
            Console.WriteLine("Загадайте число от 0 до 100");
            HiddenNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Отгадайте число от 0 до 100");

            int first = 0;
            int last = maxHiddenValue;
           
            while (true)
            {

                if (qtyAttempt == 0)
                {
                    Console.WriteLine("Ты проиграл! Привывсив количество попыток");
                    break;
                }

                int guessNumber = (first + last) / 2;
                Console.WriteLine($"пк: мое чило={guessNumber}");

                if (IsGuessed(guessNumber)) break;

                if (guessNumber > HiddenNumber)
                {
                    last = guessNumber;
                }
                else
                {
                    first = guessNumber;
                }

                qtyAttempt--;
            }
        }

        private void HumanGuesses()
        {
            Random rnd = new Random();
            HiddenNumber = rnd.Next(0, maxHiddenValue);
            Console.WriteLine("Отгадайте число от 0 до 100");

            while (true)
            {
                if (qtyAttempt == 0)
                {
                    Console.WriteLine("Ты проиграл! Привывсив количество попыток");
                    break;
                }

                int guessNumber = int.Parse(Console.ReadLine());

                if (IsGuessed(guessNumber)) break;
                qtyAttempt--;
            }  
        }

        private bool IsGuessed(int guessNumber)
        {

            if (guessNumber == HiddenNumber)
            {
                Console.WriteLine($"Победа! Ты угадал, загаданное число={guessNumber}");
                return true;
            }
            else if (guessNumber > HiddenNumber)
            {
                Console.WriteLine($"Загаданное число меньше {guessNumber}");
                return false;
            }
            else
            {
                Console.WriteLine($"Загаданное число больше {guessNumber}");
                return false;
            }
        }

    }


    public class Complex
    {
        public double Re { get; private set; }
        public double Im { get; private set; }

        public Complex(double re, double im)
        {
            Re = re;
            Im = im;
        }

        public Complex Plus(Complex number)
        {
            return new Complex(this.Re + number.Re, this.Im + number.Im); 
        }

        public Complex Minus(Complex number)
        {
            return new Complex(this.Re - number.Re, this.Im + number.Im);
        }
    }


}
