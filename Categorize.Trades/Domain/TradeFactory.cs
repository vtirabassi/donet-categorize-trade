using Categorize.Trades.Data;
using Categorize.Trades.Domain.Enums;
using Categorize.Trades.Domain.TypesTrades;
using Categorize.Trades.Utils;

namespace Categorize.Trades.Domain;

public class TradeFactory : ITradeFactory
{
    public ITrade CreateObject(BaseTrade baseTrade)
    {
        if (IsExpiredTrade(baseTrade))
            return new ExpiredTrade(baseTrade);

        return LevelRisk(baseTrade);
    }

    private static ITrade LevelRisk(BaseTrade baseTrade)
    {
        var clientSector = baseTrade.ClientSector.ParseEnum<EClientSector>();
        return clientSector switch
        {
            EClientSector.PRIVATE => ProcessPrivateSector(baseTrade),
            EClientSector.PUBLIC => ProcessPublicSector(baseTrade),
            _ => baseTrade
        };
    }

    private static ITrade ProcessPrivateSector(BaseTrade baseTrade)
    {
        return baseTrade.Value > Constants.ValuesInput.ValueToBeCompare
            ? new HighRiskTrade(baseTrade)
            : baseTrade;
    }

    private static ITrade ProcessPublicSector(BaseTrade baseTrade)
    {
        return baseTrade.Value > Constants.ValuesInput.ValueToBeCompare
            ? new MediumRiskTrade(baseTrade)
            : baseTrade;
    }

    private static bool IsExpiredTrade(BaseTrade baseTrade) =>
        (baseTrade.ReferDate - baseTrade.NextPaymentDate).TotalDays > 30;
}