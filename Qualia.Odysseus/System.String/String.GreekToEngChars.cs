public static partial class Extensions
{
    /// <summary>
    ///     Removes all diacritics, then replaces greek letters in string with greeklish equivalent eng chars.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>A string without diacretics and with its greek chars replaced by eng chars.</returns>
    public static string GreekToEngChars(this string @this)
    {
        var gr = "ΑΒΓΔΕΖΗΘΙΚΛΜΝΞΟΠΡΣΤΥΦΧΨΩαβγδεζηθικλμνξοπρστυφχψω";
        var toEng = "ABGDEZI8IKLMNJOPRSTUFXYWabgdezi8iklmnjoprstufxyw";

        return
            @this
            .RemoveDiacritics()
            .Select(@char => gr.Contains(@char) ? toEng[gr.IndexOf(@char)] : @char)
            .StringJoin("");
        ;
    }
}