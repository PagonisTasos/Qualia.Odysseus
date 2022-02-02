public static partial class Extensions
{
    /// <summary>
    ///     Makes a deep copy by serializing and deserializing the object.
    /// </summary>
    /// <typeparam name="T">Type of the object to be serialized</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <returns>A new object.</returns>
    public static T? NaiveDeepCopy<T>(this T @this)
    {
        var json = System.Text.Json.JsonSerializer.Serialize(@this);
        return System.Text.Json.JsonSerializer.Deserialize<T>(json);
    }

}

