using Categorize.Trades.Domain.Enums;

namespace Categorize.Trades.Domain.TypesTrades;

public class BaseTrade : ITrade
{
    public BaseTrade(IReadOnlyList<string> parts)
    {
        Value = double.Parse(parts[0]);
        ClientSector = parts[1];
        NextPaymentDate = DateTime.Parse(parts[2]);
        Risk = ERisk.UNDEFINED;
    }
    
    public double Value { get; }
    public string ClientSector { get; }
    public DateTime NextPaymentDate { get; }
    public ERisk Risk { get; }
}