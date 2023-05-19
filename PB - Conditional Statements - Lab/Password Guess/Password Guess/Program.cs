using System;

namespace Password_Guess
{
    class Program
    {
        static void Main(string[] args)
        {
            string pas = Console.ReadLine();
            if (pas== "s3cr3t!P@ssw0rd")
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Wrong password!");
            }
        }
    }
}
