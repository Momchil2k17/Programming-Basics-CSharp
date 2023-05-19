using System;

namespace P06.Building
{
    class Program
    {
        static void Main(string[] args)
        {
            int floor = int.Parse(Console.ReadLine());
            int rooms = int.Parse(Console.ReadLine());
            for (int fl = floor; fl >= 1; fl--)
            {
                for (int r = 0; r < rooms; r++)
                {
                    if (fl==floor)
                    {
                        Console.Write($"L{fl}{r} ");
                    }
                    else if (fl%2==0)
                    {
                        Console.Write($"O{fl}{r} ");
                    }
                    else if (fl%2!=0)
                    {
                        Console.Write($"A{fl}{r} ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
