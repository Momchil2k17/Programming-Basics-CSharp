using System;

namespace P04.Clever_Lily
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double price = double.Parse(Console.ReadLine());
            int toy = int.Parse(Console.ReadLine());
            double sum = 0;
            for (int i = 1; i <= age; i++)
            {
                if (i%2==0)
                {
                    sum += 10 * (i / 2)-1;
                }
                else
                {
                    sum += toy;
                }
            }
            if (sum>=price)
            {
                Console.WriteLine($"Yes! {sum-price:f2}");
            }
            else
            {
                Console.WriteLine($"No! {price-sum:f2}");
            }
        }
    }
}
