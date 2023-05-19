using System;

namespace P03.Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double c1 = 0,c2=0,c3=0,c4=0,c5=0;
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num<200)
                {
                    c1 +=1;
                }
                else if (num<=399)
                {
                    c2 += 1;
                }
                else if (num<=599)
                {
                    c3 += 1;
                }
                else if (num<=799)
                {
                    c4 += 1;
                }
                else if (num<=1000)
                {
                    c5 += 1;
                }

            }
            Console.WriteLine($"{c1/n*100:f2}%");
            Console.WriteLine($"{c2/n*100:f2}%");
            Console.WriteLine($"{c3/n*100:f2}%");
            Console.WriteLine($"{c4/n*100:f2}%");
            Console.WriteLine($"{c5/n*100:f2}%");
        }
    }
}
