using System;

namespace P08.Basketball_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            int tax = int.Parse(Console.ReadLine());
            double kec = 0.6 * tax;
            double ekip = 0.8 * kec;
            double topka = ekip / 4;
            double ak = topka / 5;
            double sum = tax + kec + ekip + topka + ak;
            Console.WriteLine(sum);
        }
    }
}
