﻿using System;

namespace Area_of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            string shape = Console.ReadLine();
            double area = 0;
            if (shape=="square")
            {
                double a = double.Parse(Console.ReadLine());
                area = a * a;
            }
            else if (shape=="rectangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                area = a * b;
            }
            else if (shape=="circle")
            {
                double r = double.Parse(Console.ReadLine());
                area = Math.PI * r * r;
            }
            else if (shape=="triangle")
            {
                double a = double.Parse(Console.ReadLine());
                double h = double.Parse(Console.ReadLine());
                area = a * h / 2;
            }
            Console.WriteLine($"{area:f3}");
        }
    }
}
