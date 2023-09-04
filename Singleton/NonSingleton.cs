public sealed class NonSingleton
{
    public NonSingleton(string value)
    {
        Value = value;
    }

    public string Value { get; set; }
}