using Categorize.Trades.Domain.Enums;

namespace Categorize.Trades.Domain;

public interface ITrade
{
    double Value { get; }
    string ClientSector { get; }
    DateTime NextPaymentDate { get; }
    ERisk Risk { get; }
}