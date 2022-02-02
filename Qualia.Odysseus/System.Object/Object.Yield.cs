public static partial class Extensions
{
    /// <summary>
    ///     Wraps the object in a IEnumerable.
    /// </summary>
    /// <typeparam name="T">Type of the object</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <returns>An IEnumerable containing the object.</returns>
    public static IEnumerable<T> Yield<T>(this T @this)
    {
        return new List<T> { @this };
    }
}


