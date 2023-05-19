using System;

namespace P04.Toy_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            double price = double.Parse(Console.ReadLine());
            int puzel = int.Parse(Console.ReadLine());
            int kukla = int.Parse(Console.ReadLine());
            int meche = int.Parse(Console.ReadLine());
            int minion = int.Parse(Console.ReadLine());
            int kamion = int.Parse(Console.ReadLine());

            double sum = 2.6 * puzel + 3 * kukla + 4.1 * meche + 8.2 * minion + 2 * kamion;
            int broi = puzel + kukla + meche + minion + kamion;
            if (broi>=50)
            {
                sum = 0.75 * sum;
            }
            double rent = 0.1 * sum;
            double all = sum - rent;
            if (all>=price)
            {
                Console.WriteLine($"Yes! {all-price:f2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {price-all:f2} lv needed.");
            }
        }
    }
}
