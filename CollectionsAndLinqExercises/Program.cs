using System;
using System.Collections.Generic;

namespace CollectionsAndLinqExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            var stocks = new Dictionary<string, string>();
            stocks.Add("GME", "Gamestop");
            stocks.Add("BRK-A", "Berkshire Hathaway");
            stocks.Add("TSLA", "Tesla");
            stocks.Add("DIS", "Walt Disney");

            List<(string ticker, int shares, double price)> purchases = new List<(string, int, double)>();

            purchases.Add((ticker: "GME", shares: 500, price: 53.50));
            purchases.Add((ticker: "BRK-A", shares: 1, price: 354760));
            purchases.Add((ticker: "TSLA", shares: 10, price: 849.99));
            purchases.Add((ticker: "DIS", shares: 50, price: 180.23));
            purchases.Add((ticker: "GME", shares: 500, price: 53.50));

            var purchaseInfo = new Dictionary<string, double>();
            foreach ((string ticker, int shares, double price) purchase in purchases)
            {
                if (purchaseInfo.TryGetValue(purchase.ticker, out double valuation))
                {
                    purchaseInfo[purchase.ticker] = valuation += (purchase.shares * purchase.price);
                }
                else
                {
                    purchaseInfo.Add(purchase.ticker, purchase.shares * purchase.price);
                }
            }

            Console.WriteLine("----------------------------");
            Console.WriteLine("Total Ownership Report");
            foreach ((string company, double valuation) in purchaseInfo)
            {
                Console.WriteLine($"{company}: ${valuation}");
            }
            Console.WriteLine("----------------------------");
        }
    }
}
