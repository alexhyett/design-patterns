public sealed class SimpleSingleton
{
    private SimpleSingleton() { }

    private static SimpleSingleton _instance;

    public static SimpleSingleton GetInstance(string value)
    {
        if (_instance == null)
        {
            _instance = new SimpleSingleton();
            _instance.Value = value;
        }
        return _instance;
    }

    public string Value { get; set; }
}
