using System;

namespace P06.Repainting
{
    class Program
    {
        static void Main(string[] args)
        {
            int nm = int.Parse(Console.ReadLine());
            int lb = int.Parse(Console.ReadLine());
            int lr = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());

            double nmp = (nm + 2) * 1.50;
            double lbp = (lb + 0.10 * lb) * 14.50;
            double lrp = lr * 5;
            double t = 0.40;
            double summ = nmp + lbp + lrp + t;
            double m = (summ * 30 / 100) * h;
            Console.WriteLine(summ + m);
        }
    }
}
