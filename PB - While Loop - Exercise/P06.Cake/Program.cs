using System;

namespace P06.Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int w = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());
            int n = l * w;
            int total = 0;
            int take = 0;
            string command = "";
            while (total<=n)
            {
                command = Console.ReadLine();
                if (command=="STOP")
                {
                    break;
                }
                take = int.Parse(command);
                total += take;

            }
            if (total>n)
            {
                Console.WriteLine($"No more cake left! You need {total-n} pieces more.");
            }
            else
            {
                Console.WriteLine($"{n-total} pieces are left.");
            }

        }
    }
}
