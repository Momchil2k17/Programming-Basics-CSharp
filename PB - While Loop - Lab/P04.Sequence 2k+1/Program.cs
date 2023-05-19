using System;

namespace P04.Sequence_2k_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int i = 1;
            while (i<=n)
            {
                Console.WriteLine(i);
                i = 2 * i + 1;
            }
        }
    }
}
