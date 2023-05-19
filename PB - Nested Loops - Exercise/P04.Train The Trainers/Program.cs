using System;

namespace P04.Train_The_Trainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string presentation = Console.ReadLine();
            double averageGrade = 0;
            int count = 0;
            while (presentation!="Finish")
            {
                double gradeSum = 0;
                for (int i = 0; i < n; i++)
                {
                    double grade = double.Parse(Console.ReadLine());
                    gradeSum += grade;
                }
                count++;
                averageGrade += gradeSum/n;
                Console.WriteLine($"{presentation} - {gradeSum/n:f2}.");
                presentation = Console.ReadLine();
            }
            Console.WriteLine($"Student's final assessment is {averageGrade/count:f2}.");
        }
    }
}
