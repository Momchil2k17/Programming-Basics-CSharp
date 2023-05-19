using System;

namespace P05.Account_Balance
{
    class Program
    {
        static void Main(string[] args)
        {
            double total = 0;
            string i;
            while ((i=Console.ReadLine())!="NoMoreMoney")
            {
                double m = double.Parse(i);
                if (m<0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                total += m;
                Console.WriteLine($"Increase: {m:f2}");

            }
            Console.WriteLine($"Total: {total:f2}");



        }
    }
}
