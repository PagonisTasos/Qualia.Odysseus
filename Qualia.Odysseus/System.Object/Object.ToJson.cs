public static partial class Extensions
{
    /// <summary>
    ///     Serializes the object to Json.
    /// </summary>
    /// <typeparam name="T">Type of the object to be serialized</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <returns>A string containing the object in json format.</returns>
    public static string ToJson<T>(this T @this)
    {
        return System.Text.Json.JsonSerializer.Serialize(@this);
    }

    /// <summary>
    ///     Serializes the object to Json.
    /// </summary>
    /// <typeparam name="T">Type of the object to be serialized</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <returns>A string containing the object in json format.</returns>
    public static string ToIndentedJson<T>(this T @this)
    {
        return System.Text.Json.JsonSerializer.Serialize(@this, options: new System.Text.Json.JsonSerializerOptions { WriteIndented = true });
    }
}

