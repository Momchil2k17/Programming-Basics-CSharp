using System;

namespace P05.Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            double stotinki = money * 100;
            int countOfCoins = 0;
            while (stotinki > 0)
            {
                if (stotinki >= 200)
                {
                    countOfCoins++;
                    stotinki -= 200;
                }
                else if (stotinki >= 100)
                {
                    countOfCoins++;
                    stotinki -= 100;
                }
                else if (stotinki >= 50)
                {
                    countOfCoins++;
                    stotinki -= 50;
                }
                else if (stotinki >= 20)
                {
                    countOfCoins++;
                    stotinki -= 20;
                }
                else if (stotinki >= 10)
                {
                    countOfCoins++;
                    stotinki -= 10;
                }
                else if (stotinki >= 5)
                {
                    countOfCoins++;
                    stotinki -= 5;
                }
                else if (stotinki >= 2)
                {
                    countOfCoins++;
                    stotinki -= 2;
                }
                else if (stotinki >= 1)
                {
                    countOfCoins++;
                    stotinki -= 1;
                }
                else
                {
                    stotinki = 0;
                }
                
                
            }
            Console.WriteLine(countOfCoins);
        }
    }
}
