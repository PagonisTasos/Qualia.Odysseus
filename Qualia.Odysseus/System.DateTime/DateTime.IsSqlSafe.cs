public static partial class Extensions
{
    /// <summary>
    ///     An extension method that checks if the value is greater than 1753/01/01.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>True if the value is greater than 1753/01/01.</returns>
    public static bool IsSqlSafe(this DateTime @this)
    {
        return @this.CompareTo(new DateTime(1753, 1, 1)) == -1;
    }
}