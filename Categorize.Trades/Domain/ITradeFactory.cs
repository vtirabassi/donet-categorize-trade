namespace Categorize.Trades.Domain;

public interface ITradeFactory
{
    ITrade CreateObject(TradeBase tradeBase);
}