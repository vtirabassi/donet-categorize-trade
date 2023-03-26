using Categorize.Trades.Domain.Enum;

namespace Categorize.Trades.Domain.TypesTrade;

public class HighRiskTrade : ITrade
{
    public HighRiskTrade(TradeBase tradeBase)
    {
        Value = tradeBase.Value;
        ClientSector = tradeBase.ClientSector;
        NextPaymentDate = tradeBase.NextPaymentDate;
        Risk = ERisk.HIGHRISK;
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