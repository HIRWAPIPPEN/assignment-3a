// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

namespace PrimeNumberGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the upper limit:");
            int n = int.Parse(Console.ReadLine());
            bool[] isPrime = new bool[n + 1];

            for (int i = 2; i <= n; i++)
                isPrime[i] = true;

            for (int i = 4; i <= n; i += 2)
                isPrime[i] = false;

            for (int i = 3; i * i <= n; i += 2)
            {
                if (isPrime[i])
                {
                    for (int j = i * i; j <= n; j += i)
                    {
                        isPrime[j] = false;
                    }
                }
            }

            Console.WriteLine("Prime numbers:");
            for (int i = 2; i <= n; i++)
            {
                if (isPrime[i])
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
        }
    }
}

