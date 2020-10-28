using System;

namespace SmallShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string grocery = Console.ReadLine();
            string city = Console.ReadLine();
            double amount = double.Parse(Console.ReadLine());

            double price = 0;

            if (city == "Sofia")
            {
                if (grocery == "coffee")
                {
                    price = 0.50;
                }
                else if (grocery == "water")
                {
                    price = 0.80;
                }
                else if (grocery == "beer")
                {
                    price = 1.20;
                }
                else if (grocery == "sweets")
                {
                    price = 1.45;
                }
                else if (grocery == "peanuts")
                {
                    price = 1.60;
                }
            }
            else if (city == "Plovdiv")
            {
                if (grocery == "coffee")
                {
                    price = 0.40;
                }
                else if (grocery == "water")
                {
                    price = 0.70;
                }
                else if (grocery == "beer")
                {
                    price = 1.15;
                }
                else if (grocery == "sweets")
                {
                    price = 1.30;
                }
                else if (grocery == "peanuts")
                {
                    price = 1.50;
                }
            }
            else if (city == "Varna")
            {
                if (grocery == "coffee")
                {
                    price = 0.45;
                }
                else if (grocery == "water")
                {
                    price = 0.70;
                }
                else if (grocery == "beer")
                {
                    price = 1.10;
                }
                else if (grocery == "sweets")
                {
                    price = 1.35;
                }
                else if (grocery == "peanuts")
                {
                    price = 1.55;
                }
            }
            double totalPrice = amount * price;

            Console.WriteLine(totalPrice);
        }
    }
}
