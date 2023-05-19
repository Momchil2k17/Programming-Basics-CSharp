using System;

namespace P07.Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int video = int.Parse(Console.ReadLine());
            int proc = int.Parse(Console.ReadLine());
            int ram = int.Parse(Console.ReadLine());
            double sum = 250 * video+0.35*250*video*proc+0.1*250*video*ram;
            if (video>proc)
            {
                sum = sum * 0.85;
            }
            if (budget>=sum)
            {
                Console.WriteLine($"You have {budget-sum:f2} leva left!");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {sum-budget:f2} leva more!");
            }
        }
    }
}
