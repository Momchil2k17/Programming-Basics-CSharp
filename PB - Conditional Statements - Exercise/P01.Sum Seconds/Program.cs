using System;

namespace P01.Sum_Seconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int c1 = int.Parse(Console.ReadLine());
            int c2 = int.Parse(Console.ReadLine());
            int c3 = int.Parse(Console.ReadLine());
            int sum = c1 + c2 + c3;
            int min = sum / 60;
            int sec = sum % 60;
            if (sec < 10)
            {
                Console.WriteLine($"{min}:0{sec}");
            }
            else
            {
                Console.WriteLine($"{min}:{sec}");
            }
        }
    }
}
