using System;

namespace P07.Working_Hours
{
    class Program
    {
        static void Main(string[] args)
        {
            int h = int.Parse(Console.ReadLine());
            string day = Console.ReadLine();
            if (h>=10 && h<=18 && day!="Sunday")
            {
                Console.WriteLine("open");
            }
            else
            {
                Console.WriteLine("closed");
            }
        }
    }
}
