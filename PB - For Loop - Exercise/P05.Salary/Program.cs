using System;

namespace P05.Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                string a = Console.ReadLine();
                if (a=="Facebook")
                {
                    salary -= 150;
                }
                else if (a=="Instagram")
                {
                    salary -= 100;
                }
                else if (a=="Reddit")
                {
                    salary -= 50;
                }
            }
            if (salary<=0)
            {
                Console.WriteLine("You have lost your salary.");
            }
            else
            {
                Console.WriteLine(salary);
            }
        }
    }
}
