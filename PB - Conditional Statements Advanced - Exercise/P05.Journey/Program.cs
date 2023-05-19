using System;

namespace P05.Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string accommodation,destination;
            double sum = 0;
            if (budget<=100)
            {
                destination = "Bulgaria";
                if (season=="summer")
                {
                    sum = budget * 0.3;
                    accommodation = "Camp";
                }
                else
                {
                    sum = budget * 0.7;
                    accommodation = "Hotel";
                }
            }
            else if (budget<=1000)
            {
                destination = "Balkans";
                if (season == "summer")
                {
                    sum = budget * 0.4;
                    accommodation = "Camp";
                }
                else
                {
                    sum = budget * 0.8;
                    accommodation = "Hotel";
                }
            }
            else
            {
                destination = "Europe";
                sum = budget * 0.9;
                accommodation = "Hotel";
            }
            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{accommodation} - {sum:f2}");
        }
    }
}
