using System;

namespace P07.Min_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = int.MaxValue;
            string i;
            while ((i = Console.ReadLine()) != "Stop")
            {
                int n = int.Parse(i);
                if (n < min)
                {
                    min = n;
                }
            }
            Console.WriteLine(min);
        }
    }
}
