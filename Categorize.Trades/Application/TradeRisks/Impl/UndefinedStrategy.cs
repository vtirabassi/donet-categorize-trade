using Categorize.Trades.Domain.Entities;
using Categorize.Trades.Domain.Enums;

namespace Categorize.Trades.Application.TradeRisks.Impl;

public class UndefinedStrategy : ITradeStrategy
{
    bool ITradeStrategy.IsThisRisk(BaseTrade baseTrade)
    {
        return true;
    }

    public ERisk Risk { get; } = ERisk.UNDEFINED;
}