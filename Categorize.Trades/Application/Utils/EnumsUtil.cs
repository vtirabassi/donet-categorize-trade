namespace Categorize.Trades.Application.Utils;

public static class EnumsUtil
{
    public static T ParseEnum<T>(this string value) where T : struct, Enum
    {
        return Enum.TryParse<T>(value.Trim(), true, out var result)
            ? result
            : throw new NotImplementedException();
    }
}