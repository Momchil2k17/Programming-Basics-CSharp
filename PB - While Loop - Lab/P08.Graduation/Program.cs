using System;

namespace P08.Graduation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int uCounter = 0, gCounter = 1;
            double total = 0;
            while (gCounter<=12)
            {
                double grade = double.Parse(Console.ReadLine());
                total += grade;
                if (grade<4)
                {
                    uCounter++;
                    if (uCounter>1)
                    {
                        Console.WriteLine($"{name} has been excluded at {gCounter} grade");
                        return;
                    }
                }
                else
                {
                    gCounter++;
                }
            }
            double average = total / (12 + uCounter);
            Console.WriteLine($"{name} graduated. Average grade: {average:f2}");
            
        }
    }
}
