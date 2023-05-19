using System;

namespace P08.Pet_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            int ku = int.Parse(Console.ReadLine());
            int ko = int.Parse(Console.ReadLine());
            double pr1 = ku * 2.5;
            double pr2 = ko * 4;
            double final = pr1 + pr2;
            Console.WriteLine(final + " lv.");
        }
    }
}
