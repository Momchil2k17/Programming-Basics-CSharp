using System;

namespace P06.Max_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = int.MinValue;
            string i;
            while ((i=Console.ReadLine())!="Stop")
            {
                int n = int.Parse(i);
                if (n>max)
                {
                    max = n;
                }
            }
            Console.WriteLine(max);
        }
    }
}
