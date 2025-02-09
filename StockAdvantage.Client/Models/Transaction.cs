namespace StockAdvantage.Client.Models;

public class Transaction
{
    public DateTime date { get; set; }
    
    public string shortName { get; set; }
    
    public decimal amount { get; set; }
    
    public decimal price { get; set; }
    
    public decimal totalCost { get; set; }
    
    public TransactionType transactionType { get; set; }


    public Transaction(string shortName, decimal amount, decimal price, decimal totalCost, TransactionType transactionType)
    {
        this.date = DateTime.Now;
        this.shortName = shortName;
        this.amount = amount;
        this.price = price;
        this.totalCost = totalCost;
        this.transactionType = transactionType;
    }
}