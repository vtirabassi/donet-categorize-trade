using Categorize.Trades.Application.Utils;
using Categorize.Trades.Domain.Entities;
using Categorize.Trades.Domain.Enums;

namespace Categorize.Trades.Application.TradeRisks.Impl;

public class MediumRiskStrategy : ITradeStrategy
{
    bool ITradeStrategy.IsThisRisk(BaseTrade baseTrade)
    {
        return baseTrade.EClientSector is EClientSector.PUBLIC
               & baseTrade.Value > Constants.ValuesInput.ValueToBeCompare;
    }
    
    public ERisk Risk => ERisk.MEDIUMRISK;
}