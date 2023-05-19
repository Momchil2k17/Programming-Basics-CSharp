using System;

namespace P03.New_House
{
    class Program
    {
        static void Main(string[] args)
        {
            string flower = Console.ReadLine();
            int num = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());
            double sum = 0;
            if (flower=="Roses")
            {
                if (num>80)
                {
                    sum = num * 5 * 0.9;
                }
                else
                {
                    sum = num * 5;
                }
            }
            else if (flower== "Dahlias")
            {
                if (num>90)
                {
                    sum = num * 3.8 * 0.85;
                }
                else
                {
                    sum = num * 3.8;
                }
            }
            else if (flower== "Tulips")
            {
                if (num>80)
                {
                    sum = num * 2.8 * 0.85;
                }
                else
                {
                    sum = num * 2.8;
                }
            }
            else if (flower== "Narcissus")
            {
                if (num<120)
                {
                    sum = num * 3 * 1.15;
                }
                else
                {
                    sum = num * 3;
                }
            }
            else
            {
                if (num<80)
                {
                    sum = num * 2.5 * 1.20;
                }
                else
                {
                    sum = num * 2.5;
                }
            }
            if (budget>=sum)
            {
                Console.WriteLine($"Hey, you have a great garden with {num} {flower} and {budget-sum:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {sum-budget:f2} leva more.");
            }
        }
    }
}
