using Categorize.Trades.Data;
using Categorize.Trades.Domain;
using Categorize.Trades.Domain.TypesTrades;

var pathFile = string.Concat(Directory.GetCurrentDirectory(), "../../../../Data/tradesInput.txt");
var dateRefer = Constants.ValuesInput.DateRefer;

var lines = File.ReadAllLines(pathFile);
foreach (var line in lines)
{
    var parts = line.Split(' ');
    if (parts.Length is 1)
        continue;

    var tradeBase = new BaseTrade(parts[0], parts[1], parts[2], dateRefer);
    var tradeFactory = new TradeFactory();
    var trade = tradeFactory.CreateObject(tradeBase);

    Console.WriteLine(trade.Risk);
}