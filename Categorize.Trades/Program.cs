using Categorize.Trades.Application.Services.Impl;
using Categorize.Trades.Domain.Entities;

var pathFile = string.Concat(Directory.GetCurrentDirectory(), "../../../../Data/tradesInput.txt");

var lines = File.ReadAllLines(pathFile);
foreach (var line in lines)
{
    var parts = line
        .Trim()
        .Split(' ');
    
    if (parts.Length is 1)
        continue;
    
    var tradeService = new TradeService();
    var tradeRisk = tradeService.GetTradeRisk(new BaseTrade(parts));

    Console.WriteLine(tradeRisk);
}