using System;

namespace P07.Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int w = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());
            string done = "";
            int available = w * l * h;
            int cubic = 0, total = 0;
            while (total<=available)
            {
                done = Console.ReadLine();
                if (done=="Done")
                {
                    break;
                }
                cubic = int.Parse(done);
                total += cubic;

            }
            if (total>available)
            {
                Console.WriteLine($"No more free space! You need {total-available} Cubic meters more.");
            }
            else
            {
                Console.WriteLine($"{available-total} Cubic meters left.");
            }
            
        }
    }
}
