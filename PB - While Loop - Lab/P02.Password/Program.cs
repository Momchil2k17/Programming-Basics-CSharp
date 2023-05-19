using System;

namespace P02.Password
{
    class Program
    {
        static void Main(string[] args)
        {
            string u = Console.ReadLine();
            string p = Console.ReadLine();
            string i = Console.ReadLine();
            while (i!=p)
            {
                i = Console.ReadLine();
            }
            Console.WriteLine($"Welcome {u}!");

        }
    }
}
