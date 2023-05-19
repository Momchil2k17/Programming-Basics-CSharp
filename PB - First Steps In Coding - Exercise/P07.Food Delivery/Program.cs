using System;

namespace P07.Food_Delivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int pile = int.Parse(Console.ReadLine());
            int riba = int.Parse(Console.ReadLine());
            int veg = int.Parse(Console.ReadLine());
            double p = pile * 10.35;
            double r = riba * 12.40;
            double v = veg * 8.15;
            double sum = p + r + v;
            double des = 0.2 * sum;
            Console.WriteLine(sum + des + 2.50);
        }
    }
}
