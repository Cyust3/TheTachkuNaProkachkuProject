namespace TheTachkuNaProkachkuConctrat.Extensions;

public static class StringExtensions
{
    public static bool IsEmpty(this string str)
    {
        return string.IsNullOrEmpty(str);
    }

    public static bool IsGuid(this string str)
    {
        return Guid.TryParse(str, out _);
    }
}
