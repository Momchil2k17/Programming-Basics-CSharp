using System;

namespace P02.Bonus_Score
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            double bonus = 0;
            if (num<=100)
            {
                bonus = bonus + 5;
            }
            else if (num<=1000)
            {
                bonus = num * 0.2;
            }
            else
            {
                bonus = num * 0.1;
            }
            if (num%2==0)
            {
                bonus = bonus + 1;
            }
            else if (num%5==0)
            {
                bonus = bonus + 2;
            }
            Console.WriteLine(bonus);
            Console.WriteLine(bonus+num);
            
        }
    }
}
