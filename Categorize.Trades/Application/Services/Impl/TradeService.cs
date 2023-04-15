using Categorize.Trades.Application.TradeRisks;
using Categorize.Trades.Application.TradeRisks.Impl;
using Categorize.Trades.Domain.Entities;
using Categorize.Trades.Domain.Enums;

namespace Categorize.Trades.Application.Services.Impl;

public class TradeService : ITradeService
{
    private readonly List<ITradeStrategy> _tradeStrategies = new()
    {
        new ExpiredStrategy(),
        new HighRiskStrategy(),
        new MediumRiskStrategy(),
        new UndefinedStrategy()
    };
    
    public ERisk GetTradeRisk(BaseTrade trade)
    {
        foreach (var tradeStrategy in _tradeStrategies)
        {
            if (tradeStrategy.IsThisRisk(trade))
                return tradeStrategy.Risk;
        }

        return ERisk.UNDEFINED;
    }
}