using System;

namespace P06.Oscars
{
    class Program
    {
        static void Main(string[] args)
        {
            string actorName = Console.ReadLine();
            double points = double.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            string name;
            double assessorPoints; ;
            for (int i = 1; i <=n; i++)
            {
                name = Console.ReadLine();
                assessorPoints = double.Parse(Console.ReadLine());
                points = points + name.Length * assessorPoints / 2;
                if (points > 1250.5)
                {
                    Console.WriteLine($"Congratulations, {actorName} got a nominee for leading role with {points:f1}!");
                    break;
                }
                
            }
            if(points<1250.5)
                {
                    Console.WriteLine($"Sorry, {actorName} you need {1250.5 - points:f1} more!");
                }
            
        }
    }
}
