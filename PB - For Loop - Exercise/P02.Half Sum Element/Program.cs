using System;

namespace P02.Half_Sum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int max = int.MinValue;
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                sum += num;
                if (num>max)
                {
                    max=num;
                }

            }
            int sum1 = sum - max;
            if (sum1==max)
            {
                Console.WriteLine("Yes \nSum = "+sum1);
            }
            else
            {
                Console.WriteLine("No \nDiff = "+Math.Abs(sum1-max));
            }
        }
    }
}
