using System;

namespace P03.Sum_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            while (sum<n)
            {
                int b = int.Parse(Console.ReadLine());
                sum = sum + b;
            }
            Console.WriteLine(sum);
        }
    }
}
