using System;

namespace P08.On_Time_For_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int h = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int h1 = int.Parse(Console.ReadLine());
            int m1 = int.Parse(Console.ReadLine());
            double sum = h * 60 + m;
            double sum1 = h1 * 60 + m1;
            double total = sum - sum1;
            if (total >= 0)
            {
                if (total == 0)
                {
                    Console.WriteLine("On time");
                }
                else if (total <= 30)
                {
                    Console.WriteLine("On time");
                    Console.WriteLine(total + " minutes before the start");
                }
                else if (total <= 59)
                {
                    Console.WriteLine("Early");
                    Console.WriteLine(total + " minutes before the start");
                }
                else
                {
                    double h2 = total / 60;
                    double m2 = total % 60;
                    if (m2 < 10)
                    {
                        Console.WriteLine("Early");
                        Console.WriteLine($"{Math.Floor(h2)}:0{m2} hours before the start");
                    }
                    else
                    {
                        Console.WriteLine("Early");
                        Console.WriteLine($"{Math.Floor(h2)}:{m2} hours before the start");
                    }

                }
            }
            else
            {
                double late = sum1 - sum;
                if (late <= 59)
                {
                    Console.WriteLine("Late");
                    Console.WriteLine(late + " minutes after the start");
                }
                else
                {
                    double h2 = late / 60;
                    double m2 = late % 60;
                    if (m2 < 10)
                    {
                        Console.WriteLine("Late");
                        Console.WriteLine($"{Math.Floor(h2)}:0{m2} hours after the start");
                    }
                    else
                    {
                        Console.WriteLine("Late");
                        Console.WriteLine($"{Math.Floor(h2)}:{m2} hours after the start");
                    }


                }
            }
        }
    }
}
