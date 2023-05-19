using System;

namespace P09.Ski_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int nights = days - 1;
            string acc = Console.ReadLine();
            string rating = Console.ReadLine();
            double sum = 0;
            if (acc=="room for one person")
            {
                sum = nights * 18;
            }
            else if (acc=="apartment")
            {
                if (days<10)
                {
                    sum = nights * 25 * 0.7;
                }
                else if (days>=10 && days<=15)
                {
                    sum = nights * 25 * 0.65;
                }
                else
                {
                    sum = nights * 25 * 0.5;
                }
            }
            else
            {
                if (days < 10)
                {
                    sum = nights * 35 * 0.9;
                }
                else if (days >= 10 && days <= 15)
                {
                    sum = nights * 35 * 0.85;
                }
                else
                {
                    sum = nights * 35 * 0.8;
                }
            }
            if (rating=="positive")
            {
                sum = sum * 1.25;
            }
            else if(rating=="negative")
            {
                sum = sum * 0.9;
            }
            Console.WriteLine($"{sum:f2}");
        }
    }
}
