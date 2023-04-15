using Categorize.Trades.Domain.Enums;

namespace Categorize.Trades.Domain.TypesTrades;

public class ExpiredTrade : ITrade
{
    public ExpiredTrade(BaseTrade baseTrade)
    {
        Value = baseTrade.Value;
        ClientSector = baseTrade.ClientSector;
        NextPaymentDate = baseTrade.NextPaymentDate;
        Risk = ERisk.EXPIRED;
    }

    public double Value { get; }
    public string ClientSector { get; }
    public DateTime NextPaymentDate { get; }
    public ERisk Risk { get; }

    public override string ToString()
    {
        return string.Concat(Value, "|", ClientSector, "|", NextPaymentDate);
    }
}