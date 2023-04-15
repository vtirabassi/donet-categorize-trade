using Categorize.Trades.Application.Utils;
using Categorize.Trades.Domain.Entities;
using Categorize.Trades.Domain.Enums;

namespace Categorize.Trades.Application.TradeRisks.Impl;

public class ExpiredStrategy : ITradeStrategy
{
    bool ITradeStrategy.IsThisRisk(BaseTrade baseTrade)
    {
        return (Constants.ValuesInput.DateRefer - baseTrade.NextPaymentDate).TotalDays > 30;
    }

    public ERisk Risk => ERisk.EXPIRED;
}