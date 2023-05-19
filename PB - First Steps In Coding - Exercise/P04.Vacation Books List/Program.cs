using System;

namespace P04.Vacation_Books_List
{
    class Program
    {
        static void Main(string[] args)
        {
            int br = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            int f = br / h / d;
            Console.WriteLine(f);
        }
    }
}
