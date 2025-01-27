using Microsoft.AspNetCore.SignalR;

namespace StockAdvantage.Hubs;

public class StockHub : Hub
{
    private readonly StockService _stockService;
    private readonly ILogger<StockHub> _logger;

    public StockHub(StockService stockService, ILogger<StockHub> logger)
    {
        _stockService = stockService;
        _logger = logger;
    }

    public async Task SendStockUpdate(string symbol)
    {
        var price = await _stockService.GetStockPriceAsync(symbol);
        _logger.LogInformation($"Sending update for {symbol}: {price}");
        await Clients.All.SendAsync("ReceiveStockUpdate", symbol, price);
    }
}