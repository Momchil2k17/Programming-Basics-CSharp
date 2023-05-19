using System;

namespace P01.Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string ticket = Console.ReadLine();
            int r = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int seats = r * c;
            double income = 0;
            if (ticket=="Premiere")
            {
                income = seats * 12;
            }
            else if (ticket=="Normal")
            {
                income = seats * 7.5;
            }
            else if(ticket=="Discount")
            {
                income = seats * 5;
            }
            Console.WriteLine($"{income:f2} leva");
        }
    }
}
