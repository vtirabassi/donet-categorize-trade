using Categorize.Trades.Domain.TypesTrades;

namespace Categorize.Trades.Domain;

public interface ITradeFactory
{
    ITrade CreateObject(BaseTrade baseTrade);
}