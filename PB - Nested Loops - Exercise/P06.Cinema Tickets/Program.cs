using System;

namespace P06.Cinema_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            string film = Console.ReadLine();
            string ticket = "";
            double standard = 0, kid = 0, student = 0;
            double standardTotal = 0, kidTotal = 0, studentTotal = 0;
            double allTickets = 0, totalTickets = 0;
            while (film != "Finish")
            {
                double space = double.Parse(Console.ReadLine());
                while (ticket != "End" && allTickets < space)
                {
                    ticket = Console.ReadLine();
                    if (ticket == "kid")
                    {
                        kid += 1;
                        allTickets += 1;
                    }
                    else if (ticket == "student")
                    {
                        student += 1;
                        allTickets += 1;
                    }
                    else if (ticket == "standard")
                    {
                        standard += 1;
                        allTickets += 1;
                    }
                    else
                    {

                        break;//за "Finish"
                    }
                }
                if (ticket != "Finish")
                {
                    Console.WriteLine($"{film} - {allTickets / space * 100:f2}% full.");
                    film = Console.ReadLine();
                    ticket = film;
                }
                else
                {
                    if (allTickets >= space)
                    {
                        Console.WriteLine($"{film} - {allTickets / space * 100:f2}% full.");
                    }
                    film = ticket;
                }
                standardTotal += standard;
                kidTotal += kid;
                studentTotal += student;
                totalTickets += allTickets;
                allTickets = 0;
                standard = 0;
                kid = 0;
                student = 0;
            }
            Console.WriteLine($"Total tickets: {totalTickets}");
            Console.WriteLine($"{studentTotal / totalTickets * 100:f2}% student tickets.");
            Console.WriteLine($"{standardTotal / totalTickets * 100:f2}% standard tickets.");
            Console.WriteLine($"{kidTotal / totalTickets * 100:f2}% kids tickets.");
        }
    }
}
