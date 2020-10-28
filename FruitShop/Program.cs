using System;

namespace FruitShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string day = Console.ReadLine();
            double amount = double.Parse(Console.ReadLine());

            
            

            if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday")
            {
                if (fruit == "banana")
                {
                    double price = 2.50;
                    double totalPrice = price * amount;
                    Console.WriteLine($"{totalPrice:f2}");
                }
                else if (fruit == "apple")
                {
                    double price = 1.20;
                    double totalPrice = price * amount;
                    Console.WriteLine($"{totalPrice:f2}");
                }
                else if (fruit == "orange")
                {
                    double price = 0.85;
                    double totalPrice = price * amount;
                    Console.WriteLine($"{totalPrice:f2}");
                }
                else if (fruit == "grapefruit")
                {
                    double price = 1.45;
                    double totalPrice = price * amount;
                    Console.WriteLine($"{totalPrice:f2}");
                }
                else if (fruit == "kiwi")
                {
                    double price = 2.70;
                    double totalPrice = price * amount;
                    Console.WriteLine($"{totalPrice:f2}");
                }
                else if (fruit == "pineapple")
                {
                    double price = 5.50;
                    double totalPrice = price * amount;
                    Console.WriteLine($"{totalPrice:f2}");
                }
                else if (fruit == "grapes")
                {
                    double price = 3.85;
                    double totalPrice = price * amount;
                    Console.WriteLine($"{totalPrice:f2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (day == "Saturday" || day == "Sunday")
            {
                if (fruit == "banana")
                {
                    double price = 2.70;
                    double totalPrice = price * amount;
                    Console.WriteLine($"{totalPrice:f2}");
                }
                else if (fruit == "apple")
                {
                    double price = 1.25;
                    double totalPrice = price * amount;
                    Console.WriteLine($"{totalPrice:f2}");
                }
                else if (fruit == "orange")
                {
                    double price = 0.90;
                    double totalPrice = price * amount;
                    Console.WriteLine($"{totalPrice:f2}");
                }
                else if (fruit == "grapefruit")
                {
                    double price = 1.60;
                    double totalPrice = price * amount;
                    Console.WriteLine($"{totalPrice:f2}");
                }
                else if (fruit == "kiwi")
                {
                    double price = 3.00;
                    double totalPrice = price * amount;
                    Console.WriteLine($"{totalPrice:f2}");
                }
                else if (fruit == "pineapple")
                {
                    double price = 5.60;
                    double totalPrice = price * amount;
                    Console.WriteLine($"{totalPrice:f2}");
                }
                else if (fruit == "grapes")
                {
                    double price = 4.20;
                    double totalPrice = price * amount;
                    Console.WriteLine($"{totalPrice:f2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else
            {
                Console.WriteLine("error");
            }
            
        }
    }
}
