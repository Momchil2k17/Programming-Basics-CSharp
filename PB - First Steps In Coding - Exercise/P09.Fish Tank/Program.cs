using System;

namespace P09.Fish_Tank
{
    class Program
    {
        static void Main(string[] args)
        {
            int l = int.Parse(Console.ReadLine());
            int w = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());
            double p = double.Parse(Console.ReadLine());
            p = p / 100;
            double obem = l * w * h;
            double lit = obem * 0.001;
            Console.WriteLine(lit * (1 - p));
        }
    }
}
