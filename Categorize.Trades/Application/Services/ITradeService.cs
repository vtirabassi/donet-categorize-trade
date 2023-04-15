using Categorize.Trades.Domain.Entities;
using Categorize.Trades.Domain.Enums;

namespace Categorize.Trades.Application.Services;

public interface ITradeService
{
    ERisk GetTradeRisk(BaseTrade trade);
}