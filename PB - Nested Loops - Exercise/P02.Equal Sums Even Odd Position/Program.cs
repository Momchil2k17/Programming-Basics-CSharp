using System;

namespace P02.Equal_Sums_Even_Odd_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            for (int i = first; i <=second; i++)
            {
                string current = i.ToString();
                int oddSum = 0;
                int evenSum = 0;
                for (int j = 0; j < current.Length; j++)
                {
                    int digit = int.Parse(current[j].ToString());
                    if (j%2==0)
                    {
                        evenSum += digit;
                    }
                    else
                    {
                        oddSum += digit;
                    }

                }
                if (evenSum==oddSum)
                {
                    Console.Write(i+" ");
                }
            }

        }
    }
}
