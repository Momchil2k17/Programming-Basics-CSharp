using System;

namespace P08.Lunch_Break
{
    class Program
    {
        static void Main(string[] args)
        {
            string serial = Console.ReadLine();
            int ep = int.Parse(Console.ReadLine());
            int br = int.Parse(Console.ReadLine());
            double time = br * 5 / 8.0;
            if (ep<=time)
            {
                Console.WriteLine($"You have enough time to watch {serial} and left with {Math.Ceiling(time-ep)} minutes free time.");
            }
            else
            {
                Console.WriteLine($"You don't have enough time to watch {serial}, you need {Math.Ceiling(ep-time)} more minutes.");
            }

        }
    }
}
