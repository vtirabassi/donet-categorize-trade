using Categorize.Trades.Domain;
using Categorize.Trades.Domain.TypesTrades;

var pathFile = string.Concat(Directory.GetCurrentDirectory(), "../../../../Data/tradesInput.txt");

var lines = File.ReadAllLines(pathFile);
foreach (var line in lines)
{
    var parts = line
        .Trim()
        .Split(' ');
    
    if (parts.Length is 1)
        continue;
    
    var tradeBase = new BaseTrade(parts);
    var tradeFactory = new TradeFactory();
    var trade = tradeFactory.CreateObject(tradeBase);

    Console.WriteLine(trade.Risk);
}