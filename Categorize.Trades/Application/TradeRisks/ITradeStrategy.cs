using Categorize.Trades.Domain.Entities;
using Categorize.Trades.Domain.Enums;

namespace Categorize.Trades.Application.TradeRisks;

public interface ITradeStrategy
{
    bool IsThisRisk(BaseTrade baseTrade);
    ERisk Risk { get; }

}