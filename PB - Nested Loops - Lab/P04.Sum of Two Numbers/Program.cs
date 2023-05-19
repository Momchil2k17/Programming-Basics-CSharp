using System;

namespace P04.Sum_of_Two_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int counter = 0,first=0,second=0;
            bool flag = false;
            for (int i = start; i <=end; i++)
            {
                for (int j = start; j <=end; j++)
                {
                    counter++;
                    if ((i + j) == m)
                    {
                        flag = true;
                        first = i;
                        second = j;
                        break;
                    }
                }
                if (flag==true)
                {
                    break;
                }
            }
            if (flag==false)
            {
                Console.WriteLine($"{counter} combinations - neither equals {m}");
            }
            else
            {
                Console.WriteLine($"Combination N:{counter} ({first} + {second} = {m})");
            }
        }
    }
}
