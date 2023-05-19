using System;

namespace P03.Deposit_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double dep = double.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            double p = double.Parse(Console.ReadLine());
            p = p / 100;
            double sum = dep + m * ((dep * p) / 12);
            Console.WriteLine(sum);
        }
    }
}
