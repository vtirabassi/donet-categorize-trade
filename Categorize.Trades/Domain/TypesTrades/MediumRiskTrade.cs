using Categorize.Trades.Domain.Enums;

namespace Categorize.Trades.Domain.TypesTrades;

public class MediumRiskTrade : ITrade
{
    public MediumRiskTrade(BaseTrade baseTrade)
    {
        Value = baseTrade.Value;
        ClientSector = baseTrade.ClientSector;
        NextPaymentDate = baseTrade.NextPaymentDate;
        Risk = ERisk.MEDIUMRISK;
    }

    public double Value { get; }
    public string ClientSector { get; }
    public DateTime NextPaymentDate { get; }
    public ERisk Risk { get; }
    public bool IsPoliticalllyExposed { get; }

    public override string ToString()
    {
        return string.Concat(Value, "|", ClientSector, "|", NextPaymentDate);
    }
}