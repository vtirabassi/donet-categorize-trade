using Categorize.Trades.Domain.Enum;

namespace Categorize.Trades.Domain.TypesTrade;

public class ExpiredTrade : ITrade
{
    public ExpiredTrade(TradeBase tradeBase)
    {
        Value = tradeBase.Value;
        ClientSector = tradeBase.ClientSector;
        NextPaymentDate = tradeBase.NextPaymentDate;
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