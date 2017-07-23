using System;

namespace dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            Dictionary<string, string> stocks = new Dictionary<string, string>();

            stocks.Add("GM", "General Motors");
            stocks.Add("CAT", "Caterpillar");
            stocks.Add("HCA", "Hospital Corporation of America");
            stocks.Add("AAPL", "Apple Inc");
            stocks.Add("HCA", "Hospital Corporation of America");

            string GM = stocks["GM"];
            string CAT = stocks["CAT"];
            string HCA = stocks["HCA"];
            string AAPL = stocks["Apple"];
            string GOOGL = stocks["Google Alphabet"];

            Dictionary<string, string> stocks = new Dictionary<string, string>();

            List<(string ticker, int shares, double price)> purchases = new List<(string, int, double)>();

            purchases.Add((ticker: "GE", shares: 150, price: 23.21));
            purchases.Add((ticker: "GE", shares: 32, price: 17.87));
            purchases.Add((ticker: "GE", shares: 80, price: 19.02));

            purchases.Add((ticker: "CAT", shares: 25, price: 108.24));
            purchases.Add((ticker: "CAT", shares: 34, price: 107.33));
            purchases.Add((ticker: "CAT", shares: 20, price: 109.18));

            purchases.Add((ticker: "HCA", shares: 100, price: 86.40));
            purchases.Add((ticker: "HCA", shares: 80, price: 88.72));
            purchases.Add((ticker: "HCA", shares: 92, price: 89.23));

            purchases.Add((ticker: "AAPL", shares: 75, price: 145.53));
            purchases.Add((ticker: "AAPL", shares: 100, price: 146.82));
            purchases.Add((ticker: "AAPL", shares: 90, price: 142.98));

            purchases.Add((ticker: "GOOGL", shares: 20, price: 953.53));
            purchases.Add((ticker: "GOOGL", shares: 15, price: 962.17));
            purchases.Add((ticker: "GOOGL", shares: 20, price: 957.78));


        }
    }
}
