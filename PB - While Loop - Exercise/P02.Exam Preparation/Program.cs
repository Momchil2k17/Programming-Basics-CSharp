using System;

namespace P02.Exam_Preparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int badMarks = int.Parse(Console.ReadLine());
            int pC = 0,mC=0;
            int grade = 0;
            double total = 0;
            string input,lastProblem="";
            while ((input=Console.ReadLine())!="Enough")
            {
                pC++;
                grade = int.Parse(Console.ReadLine());
                if (grade<=4)
                {
                    mC++;
                }
                if (mC>=badMarks)
                { 
                    break;
                }
                total += grade;
                lastProblem = input;

            }
            if (mC >= badMarks)
            {
                Console.WriteLine($"You need a break, {badMarks} poor grades.");
            }
            else
            {
            Console.WriteLine($"Average score: {total/pC:f2}");
            Console.WriteLine($"Number of problems: {pC}");
            Console.WriteLine($"Last problem: {lastProblem}");
            }
            
        }
    }
}
