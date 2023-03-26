using Categorize.Trades.Domain;

var pathFile = string.Concat(Directory.GetCurrentDirectory(), "../../../../Data/tradesInput.txt");
var dateRefer = DateTime.Now;

var lines = File.ReadAllLines(pathFile);
foreach (var line in lines)
{
    var parts = line.Split(' ');
    if (parts.Length is 1)
        continue;

    var tradeBase = new TradeBase(parts[0], parts[1], parts[2], dateRefer);
    var tradeFactory = new TradeFactory();
    var trade = tradeFactory.CreateObject(tradeBase);

    Console.WriteLine(trade.Risk);
}