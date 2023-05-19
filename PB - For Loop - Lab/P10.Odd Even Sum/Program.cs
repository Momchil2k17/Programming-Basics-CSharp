using System;

namespace P10.Odd_Even_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int e = 0;
            int o = 0;
            for (int i = 1; i <= n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (i%2==0)
                {
                    e += num;
                }
                else
                {
                    o += num;    
                }
            }
            if (e == o)
            {
                Console.WriteLine("Yes \nSum = " + e);
            }
            else
            {
                int diff = Math.Abs(o - e);
                Console.WriteLine("No \nDiff = " + diff);
            }
        }
    }
}
