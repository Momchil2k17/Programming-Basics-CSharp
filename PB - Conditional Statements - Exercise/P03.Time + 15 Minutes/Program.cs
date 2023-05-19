using System;

namespace Time___15_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int h = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int sum = h * 60 + m + 15;
            h = sum / 60;
            m = sum % 60;
            if (h>23)
            {
                h = 0;
                if (m<10)
                {
                    Console.WriteLine($"{h}:0{m}");
                }
                else
                {
                    Console.WriteLine($"{h}:{m}");
                }
            }
            else if (m<10)
            {
                Console.WriteLine($"{h}:0{m}");
            }
            else
            {
                Console.WriteLine($"{h}:{m}");
            }
            

            
            

        }
    }
}
