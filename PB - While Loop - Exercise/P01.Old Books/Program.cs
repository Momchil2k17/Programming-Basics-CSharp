using System;

namespace P01.Old_Books
{
    class Program
    {
        static void Main(string[] args)
        {
            string book = Console.ReadLine();
            string search;
            int counter = 0;
            while ((search=Console.ReadLine())!="No More Books")
            {
                
                if (search==book)
                {
                    Console.WriteLine($"You checked {counter} books and found it.");
                    break;
                }
                else
                {
                    counter++;
                }
            }
            if (search!=book)
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {counter} books.");
            }
            

        }
    }
}
