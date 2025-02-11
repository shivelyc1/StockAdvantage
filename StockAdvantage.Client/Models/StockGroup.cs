namespace StockAdvantage.Client.Models;

public class StockGroup
{
    public string Symbol { get; set; }
    public decimal NumberOfShares { get; set; }
    
    public decimal LatestPrice { get; set; }

    public StockGroup(string symbol, decimal latestPrice, decimal numberOfShares)
    {
        Symbol = symbol;
        NumberOfShares = numberOfShares;
        LatestPrice = latestPrice;
    }

    public StockGroup(string symbol, decimal latestPrice)
    {
        Symbol = symbol;
        LatestPrice = latestPrice;
        NumberOfShares = 0;
    }
}