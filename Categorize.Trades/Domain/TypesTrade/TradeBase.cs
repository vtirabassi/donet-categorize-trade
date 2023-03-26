using Categorize.Trades.Domain.Enum;

namespace Categorize.Trades.Domain;

public class TradeBase : ITrade
{
    public TradeBase(string value, string clientSector, string nextPaymentDate, DateTime referDate)
    {
        Value = double.Parse(value);
        ClientSector = clientSector;
        NextPaymentDate = DateTime.Parse(nextPaymentDate);
        Risk = ERisk.UNDEFINED;
        ReferDate = referDate;
    }
    
    public double Value { get; }
    public string ClientSector { get; }
    public DateTime NextPaymentDate { get; }
    public ERisk Risk { get; }

    public DateTime ReferDate { get; }
}