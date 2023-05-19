using System;

namespace P06.Operations_Between_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = int.Parse(Console.ReadLine());
            double b = int.Parse(Console.ReadLine());
            string symbol = Console.ReadLine();
            double result=0;
            if (symbol == "+")
            {
                result = a + b;
                if (result % 2 == 0)
                {
                    Console.WriteLine($"{a} + {b} = {result} - even");
                }
                else
                {
                    Console.WriteLine($"{a} + {b} = {result} - odd");
                }
            }
            else if (symbol == "-")
            {
                result = a - b;
                if (result % 2 == 0)
                {
                    Console.WriteLine($"{a} - {b} = {result} - even");
                }
                else
                {
                    Console.WriteLine($"{a} - {b} = {result} - odd");
                }
            }
            else if (symbol == "*")
            {
                result = a * b;
                if (result % 2 == 0)
                {
                    Console.WriteLine($"{a} * {b} = {result} - even");
                }
                else
                {
                    Console.WriteLine($"{a} * {b} = {result} - odd");
                }
            }
            else if (symbol == "/")
            {
                
                if (b != 0)
                {
                    result = a / b;
                    Console.WriteLine($"{a} / {b} = {result:f2}");
                }
                else
                {
                    Console.WriteLine($"Cannot divide {a} by zero");
                }
            }
            else 
            {
                
                if (b != 0)
                { 
                    result = a % b;
                    Console.WriteLine($"{a} % {b} = {result}");
                }
                else
                {
                    Console.WriteLine($"Cannot divide {a} by zero");
                }

            }

        }
    }
}
