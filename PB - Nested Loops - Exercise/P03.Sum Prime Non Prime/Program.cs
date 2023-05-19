using System;

namespace P03.Sum_Prime_Non_Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            string i=Console.ReadLine();
            int primeSum = 0, nonPrime = 0;
            while (i!="stop")
            {
                int n = int.Parse(i);
                if (n<0)
                {
                    Console.WriteLine("Number is negative.");
                    i = Console.ReadLine();
                    continue;
                }
                bool isPrime = true;
                for (int j = 2; j <n; j++)
                {
                    if (n%j==0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                   primeSum += n;  
                }
                else
                {
                   nonPrime += n;
                }
                i = Console.ReadLine();
            }
            Console.WriteLine($"Sum of all prime numbers is: {primeSum}");
            Console.WriteLine($"Sum of all non prime numbers is: {nonPrime}");
        }
    }
}
