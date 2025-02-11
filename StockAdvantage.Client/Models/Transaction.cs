namespace StockAdvantage.Client.Models;

public class Transaction : IComparer<Transaction>
{
    public DateTime date { get; set; }

    public string shortName { get; set; }

    public decimal amount { get; set; }

    public decimal price { get; set; }
    public decimal profit { get; set; }

    public TransactionType transactionType { get; set; }


    public Transaction(string shortName, decimal amount, decimal price, TransactionType transactionType)
    {
        this.date = DateTime.Now;
        this.shortName = shortName;
        this.amount = amount;
        this.price = price;
        this.transactionType = transactionType;
    }

    public Transaction(string shortName, decimal amount, decimal price, TransactionType transactionType, decimal profit)
    {
        this.date = DateTime.Now;
        this.shortName = shortName;
        this.amount = amount;
        this.price = price;
        this.profit = profit;
        this.transactionType = transactionType;
    }


    public int Compare(Transaction? x, Transaction? y)
    {
        if (ReferenceEquals(x, y)) return 0;
        if (y is null) return 1;
        if (x is null) return -1;
        return x.date.CompareTo(y.date);
    }
}