public sealed class LazySingleton
{
    private LazySingleton() { }
    private static readonly Lazy<LazySingleton> _lazy = new Lazy<LazySingleton>(() => new LazySingleton());

    public static LazySingleton GetInstance(string value)
    {
        var instance = _lazy.Value;
        instance.Value = value;

        return instance;
    }

    public string Value { get; set; }
}