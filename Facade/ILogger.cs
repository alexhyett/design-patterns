public interface ILogger
{
    void Information(string message);

    void Error(string message, Exception? ex = null);

    void Fatal(string message, Exception? ex = null);
}