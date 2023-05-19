using System;

namespace P07.Projects_Creation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int proekt = int.Parse(Console.ReadLine());
            int chas = proekt * 3;
            Console.WriteLine($"The architect {name} will need {chas} hours to complete {proekt} project/s.");
        }
    }
}
