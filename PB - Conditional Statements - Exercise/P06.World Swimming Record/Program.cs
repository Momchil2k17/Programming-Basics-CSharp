using System;

namespace P06.World_Swimming_Record
{
    class Program
    {
        static void Main(string[] args)
        {
            double record = double.Parse(Console.ReadLine());
            double m = double.Parse(Console.ReadLine());
            double sec = double.Parse(Console.ReadLine());
            double delay = Math.Floor(m / 15) * 12.5;
            double sum = m * sec +delay ;
            if (sum>=record)
            {
                Console.WriteLine($"No, he failed! He was {sum-record:f2} seconds slower.");
            }
            else
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {sum:f2} seconds.");  
            }
            
            
        }
    }
}
