using Categorize.Trades.Application.Utils;
using Categorize.Trades.Domain.Enums;

namespace Categorize.Trades.Domain.Entities;

public class BaseTrade : ITrade
{
    public BaseTrade(IReadOnlyList<string> parts)
    {
        Value = double.Parse(parts[0]);
        ClientSector = parts[1];
        EClientSector =  parts[1].ParseEnum<EClientSector>();
        NextPaymentDate = DateTime.Parse(parts[2]);
    }
    
    public double Value { get; }
    public string ClientSector { get; }
    public EClientSector EClientSector { get; }
    public DateTime NextPaymentDate { get; }
}