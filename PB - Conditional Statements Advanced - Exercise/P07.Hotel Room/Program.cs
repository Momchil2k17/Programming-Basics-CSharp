using System;

namespace P07.Hotel_Room
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            double studioSum=0, apartSum=0;
            if (month == "May" || month == "October")
            {
                if (n > 7 && n <= 14)
                {
                    studioSum = n * 50 * 0.95;
                    apartSum = n * 65;
                }
                else if (n > 14)
                {
                    studioSum = n * 50 * 0.70;
                    apartSum = n * 65 * 0.9;
                }
                else
                {
                    studioSum = n * 50;
                    apartSum = n * 65;
                }
            }
            else if (month == "June" || month=="September")
            {
                if (n>14)
                {
                    studioSum = n * 75.2 * 0.80;
                    apartSum = n * 68.7 * 0.9;
                }
                else
                {
                    studioSum = n * 75.2;
                    apartSum = n * 68.7;
                }
            }
            else
            {
                if (n > 14)
                {
                    apartSum = n * 77 * 0.9;
                    studioSum = n * 76;
                }
                else
                {
                    studioSum = n * 76;
                    apartSum = n * 77;
                }
            }
            Console.WriteLine($"Apartment: {apartSum:f2} lv.");
            Console.WriteLine($"Studio: {studioSum:f2} lv.");
        }
    }
}
