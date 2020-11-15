using System;

namespace PrimeNumber
{
    class Program
    {
        static bool PrimeNumber(int num)
        {
            if (num < 2)
            {
                Console.WriteLine($"Number {num} is NOT prime\n");

                return false;
            }

            //for (int i = 2, max = Convert.ToInt32(Math.Sqrt(num)); i <= max; i++)
            for (int i = 2; i * i <= num; i++)
            {
                if (num % i == 0)
                {
                    Console.WriteLine($"Number {num} is NOT prime\n");

                    return false;
                }
            }

            Console.WriteLine($"Number {num} is prime\n");

            return true;
        }

        static void Main(string[] args)
        {
            PrimeNumber(23);   
        }
    }
}
