using System;

namespace P05.Travelling
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();
            while (destination!="End")
            {
                double budget = double.Parse(Console.ReadLine());
                double sum = 0;
                while (sum < budget)
                {
                    double addMoney = double.Parse(Console.ReadLine());
                    sum += addMoney;
                }
                Console.WriteLine($"Going to {destination}!");
                destination = Console.ReadLine();
            }
        }
    }
}
