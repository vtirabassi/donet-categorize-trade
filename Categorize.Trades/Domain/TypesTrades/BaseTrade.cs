using Categorize.Trades.Domain.Enums;

namespace Categorize.Trades.Domain.TypesTrades;

public class BaseTrade : ITrade
{
    public BaseTrade(string value, string clientSector, string nextPaymentDate, DateTime referDate)
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