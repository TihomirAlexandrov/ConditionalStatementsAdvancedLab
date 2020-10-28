using System;

namespace TradeCommissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            double volumeOfSales = double.Parse(Console.ReadLine());

            double commission = 0;

            if (volumeOfSales >= 0 && volumeOfSales <= 500)
            {
                switch (town)
                {
                    case "Sofia":
                        commission = 0.05;
                        break;
                    case "Varna":
                        commission = 0.045;
                        break;
                    case "Plovdiv":
                        commission = 0.055;
                        break;
                }
            }
            else if (volumeOfSales > 500 && volumeOfSales <= 1000)
            {
                switch (town)
                {
                    case "Sofia":
                        commission = 0.07;
                        break;
                    case "Varna":
                        commission = 0.075;
                        break;
                    case "Plovdiv":
                        commission = 0.08;
                        break;
                }
            }
            else if (volumeOfSales > 1000 && volumeOfSales <= 10000)
            {
                switch (town)
                {
                    case "Sofia":
                        commission = 0.08;
                        break;
                    case "Varna":
                        commission = 0.1;
                        break;
                    case "Plovdiv":
                        commission = 0.12;
                        break;
                }
            }
            else if (volumeOfSales > 10000)
            {
                switch (town)
                {
                    case "Sofia":
                        commission = 0.12;
                        break;
                    case "Varna":
                        commission = 0.13;
                        break;
                    case "Plovdiv":
                        commission = 0.145;
                        break;
                }
            }

            if (commission != 0)
            {
                double commissionFee = volumeOfSales * commission;
                Console.WriteLine($"{commissionFee:f2}");
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
