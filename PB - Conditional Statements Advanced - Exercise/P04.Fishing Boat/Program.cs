using System;

namespace P04.Fishing_Boat
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();  
            int num = int.Parse(Console.ReadLine());
            double sum = 0;
            if (season=="Spring")
            {
                if (num<=6)
                {
                    sum = 3000 * 0.9;
                }
                else if (num>7 && num<=11)
                {
                    sum=3000*0.85;
                }
                else 
                {
                    sum = 3000 * 0.75;
                }
            }
            else if (season=="Summer" || season=="Autumn")
            {
                if (num <= 6)
                {
                    sum = 4200 * 0.9;
                }
                else if (num > 7 && num <= 11)
                {
                    sum = 4200 * 0.85;
                }
                else
                {
                    sum = 4200 * 0.75;
                }
            }
            else
            {
                if (num <= 6)
                {
                    sum = 2600 * 0.9;
                }
                else if (num > 7 && num <= 11)
                {
                    sum = 2600 * 0.85;
                }
                else
                {
                    sum = 2600 * 0.75;
                }
            }
            if (num%2==0 && season!="Autumn")
            {
                sum = sum * 0.95;
            }
            if (budget>=sum)
            {
                Console.WriteLine($"Yes! You have {budget-sum:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {sum-budget:f2} leva.");
            }

        }
    }
}
