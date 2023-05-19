using System;

namespace P03.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double neededMoney = double.Parse(Console.ReadLine());
            double balance = double.Parse(Console.ReadLine());
            int spendCounter = 0,dayCounter=0;
            while (spendCounter<5)
            {
            string action=Console.ReadLine();
                dayCounter++;
                double moneyChange = double.Parse(Console.ReadLine());
                if (action=="spend")
                {
                    spendCounter++;
                    if (balance<moneyChange)
                    {
                        balance = 0;
                    }
                    else
                    {
                        balance -= moneyChange;
                    }
                }
                else if(action=="save")
                {
                    spendCounter = 0;
                    balance += moneyChange;
                }
            
              
                if (balance>=neededMoney)
                {
                    Console.WriteLine($"You saved the money for {dayCounter} days.");
                    break;
                }
            }
            if (spendCounter>=5)
            {
                Console.WriteLine("You can't save the money.");
                Console.WriteLine(dayCounter);
            }
            


        }
    }
}
