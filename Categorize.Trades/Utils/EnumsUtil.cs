namespace Categorize.Trades.Utils;

public static class EnumsUtil
{
    public static T ParseEnum<T>(this string value) where T : struct, Enum
    {
        return Enum.TryParse<T>(value, true, out var result)
            ? result
            : throw new NotImplementedException();
    }
}