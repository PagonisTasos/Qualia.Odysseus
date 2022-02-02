public static partial class Extensions
{
    public static T RunAsSync<T>(this Func<Task<T>> func)
    {
        return Task.Run(func).GetAwaiter().GetResult();
    }

    public static T RunSync<T>(Func<Task<T>> func)
    {
        return Task.Run(func).GetAwaiter().GetResult();
    }
}
