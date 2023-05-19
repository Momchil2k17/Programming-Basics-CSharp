using System;

namespace P07.Trekking_Mania
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double c1 = 0, c2 = 0, c3 = 0, c4 = 0, c5 = 0;
            double n1 = 0;
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num <=5)
                {
                    c1 += num;
                 
                }
                else if (num <= 12)
                {
                    c2 += num;
              
                }
                else if (num <= 25)
                {
                    c3 += num;
                
                }
                else if (num <= 40)
                {
                    c4 += num;
                    
                }
                else if (num>=41)
                {
                    c5 += num;
                    
                }
                n1 += num;

            }
            Console.WriteLine($"{c1 / n1 * 100:f2}%");
            Console.WriteLine($"{c2 / n1 * 100:f2}%");
            Console.WriteLine($"{c3 / n1 * 100:f2}%");
            Console.WriteLine($"{c4 / n1 * 100:f2}%");
            Console.WriteLine($"{c5 / n1 * 100:f2}%");
        }
    }
}
