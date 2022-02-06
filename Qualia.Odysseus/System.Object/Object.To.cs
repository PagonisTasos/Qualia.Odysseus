public static partial class Extensions
{
    /// <summary>
    /// A T extension method that chains a func to the object and returns its result.
    /// </summary>
    /// <typeparam name="Tin"></typeparam>
    /// <typeparam name="Tout"></typeparam>
    /// <param name="this">The object to act on. (is passed to the func as a param)</param>
    /// <param name="func">The func to be executed.</param>
    /// <returns>The result of the given function </returns>
    public static Tout To<Tin, Tout>(this Tin @this, Func<Tin, Tout> func)
    {
        return func(@this);
    }
}