using Categorize.Trades.Domain.TypesTrade;

namespace Categorize.Trades.Domain;

public class TradeFactory : ITradeFactory
{
    public ITrade CreateObject(TradeBase tradeBase)
    {
        if (IsExpiredTrade(tradeBase))
            return new ExpiredTrade(tradeBase);

        return LevelRisck(tradeBase);
    }

    private static ITrade LevelRisck(TradeBase tradeBase)
    {
        return new HighRiskTrade(tradeBase);
    }

    private static bool IsExpiredTrade(TradeBase tradeBase) => 
        (tradeBase.ReferDate - tradeBase.NextPaymentDate).TotalDays > 30;
    
    
}