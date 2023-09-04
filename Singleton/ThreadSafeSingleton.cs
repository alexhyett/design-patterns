using System;
using System.Threading;

public sealed class ThreadSafeSingleton
{
    private ThreadSafeSingleton() { }

    private static readonly object _lock = new object();

    private static ThreadSafeSingleton _instance;

    public static ThreadSafeSingleton GetInstance(string value)
    {
        if (_instance == null)
        {
            lock (_lock)
            {
                if (_instance == null)
                {
                    _instance = new ThreadSafeSingleton();
                    _instance.Value = value;
                }
            }
        }
        return _instance;
    }

    public string Value { get; set; }
}
