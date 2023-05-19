using System;

namespace P04.Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            int steps = 0;
            int totalSteps = 0;
            string home="";
            while (totalSteps<10000)
            {
                home = Console.ReadLine();
                if (home=="Going home")
                {
                    break;
                }
                steps = int.Parse(home);
                totalSteps += steps;
            }
            if (home=="Going home")
            {
                steps = int.Parse(Console.ReadLine());
                totalSteps += steps;
            }
            if (totalSteps>=10000)
            {
                Console.WriteLine("Goal reached! Good job!");
                Console.WriteLine($"{totalSteps-10000} steps over the goal!");
            }
            else
            {
                Console.WriteLine($"{10000-totalSteps} more steps to reach goal.");
            }
        }
    }
}
