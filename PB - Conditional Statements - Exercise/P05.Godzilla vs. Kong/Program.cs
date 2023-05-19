using System;

namespace P05.Godzilla_vs._Kong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int stat = int.Parse(Console.ReadLine());
            double outfitPrice = double.Parse(Console.ReadLine());
            double decor = 0.1 * budget;
            double sum = 0;
            if (stat>150)
            {
                outfitPrice *= 0.9;
            }
            sum = decor + stat * outfitPrice;
            if (budget>=sum)
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {budget-sum:f2} leva left.");
            }
            else
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {sum-budget:f2} leva more.");
            }
            
        }
    }
}
