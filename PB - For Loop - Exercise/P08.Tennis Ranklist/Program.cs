using System;

namespace P08.Tennis_Ranklist
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            int p1 = 0;
            double cw = 0,cf=0,csf=0;
            string phase = "";
            for (int i = 0; i < n; i++)
            {
                phase = Console.ReadLine();
                if (phase=="W")
                {
                    p = p + 2000;
                    cw += 1;
                }
                else if (phase=="F")
                {
                    p = p + 1200;
                    cf += 1;
                }
                else if (phase=="SF")
                {
                    p = p + 720;
                    csf += 1;
                }
            }
            double average=(cw*2000+cf*1200+csf*720)/n;
            Console.WriteLine($"Final points: {p}");
            Console.WriteLine($"Average points: {Math.Floor(average)}");
            Console.WriteLine($"{cw/n*100.0:f2}%");

        }
    }
}
