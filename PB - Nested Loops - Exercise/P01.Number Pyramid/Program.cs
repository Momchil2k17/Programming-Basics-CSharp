using System;

namespace P01.Number_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int num = 1;
            bool count = false;
            for (int rows = 1; rows <=n; rows++)
            {
                for (int cols = 1; cols <=rows; cols++)
                {
                    if (num>n)
                    {
                        count = true;
                        break;
                    }
                    Console.Write(num+" ");
                    num++;
                }
                if (count==true)
                {
                    break;
                }
                    Console.WriteLine();
         
            }
        }
    }
}
