using Categorize.Trades.Domain.Enum;

namespace Categorize.Trades.Domain;

public interface ITrade
{
    double Value { get; }
    string ClientSector { get; }
    DateTime NextPaymentDate { get; }
    ERisk Risk { get; }
}