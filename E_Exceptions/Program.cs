using System;
using System.IO;

namespace E_Exceptions
{
    // custom exception type)
    public class CreditCardWithDrawException : Exception
    {

    }

    class Program
    {
        static void Main(string[] args)
        {
            FileStream file = null;

            try
            {
                file = File.Open("temp.txt", FileMode.Open);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                if (file != null)
                {
                    file.Dispose();
                }
            }

            Console.ReadLine();

            Console.WriteLine("Please input a number");

            string result = Console.ReadLine();

            int number = 0;

            try
            {
                number = int.Parse(result);
            }
            catch (OverflowException ex)
            {

            }
            catch (FormatException ex)
            {
                Console.WriteLine("A format exception has occured.");
                Console.WriteLine("Information is below:");
                Console.WriteLine(ex.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            Console.WriteLine(number);
        }
    }
}
