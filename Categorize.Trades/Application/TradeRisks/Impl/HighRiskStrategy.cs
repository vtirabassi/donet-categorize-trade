using Categorize.Trades.Application.Utils;
using Categorize.Trades.Domain.Entities;
using Categorize.Trades.Domain.Enums;

namespace Categorize.Trades.Application.TradeRisks.Impl;

public class HighRiskStrategy : ITradeStrategy
{
    bool ITradeStrategy.IsThisRisk(BaseTrade baseTrade)
    {
        return baseTrade.EClientSector is EClientSector.PRIVATE
               & baseTrade.Value > Constants.ValuesInput.ValueToBeCompare;
    }

    public ERisk Risk => ERisk.HIGHRISK;
}