using System;

namespace P09.Yard_Greening
{
    class Program
    {
        static void Main(string[] args)
        {
            double kvm = double.Parse(Console.ReadLine());
            double price = kvm * 7.61;
            double fprice = price - 0.18 * price;
            Console.WriteLine("The final price is: " + fprice + " lv.");
            Console.WriteLine("The discount is: " + 0.18 * price + " lv.");
        }
    }
}
