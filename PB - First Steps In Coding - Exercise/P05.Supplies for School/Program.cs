using System;

namespace P05.Supplies_for_School
{
    class Program
    {
        static void Main(string[] args)
        {
            int h = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            double price = (h * 5.80) + (m * 7.20) + (p * 1.20);
            Console.WriteLine(price - (price * d / 100));
        }
    }
}
