public class Logger : ILogger
{
    private readonly BadLogger _logger;
    public Logger()
    {
        _logger = new BadLogger();
    }

    public void Information(string message)
    {
        _logger.Log(message, LogType.Info, null);
    }

    public void Error(string message, Exception? ex = null)
    {
        _logger.Log(message, LogType.Error, ex);
    }

    public void Fatal(string message, Exception? ex = null)
    {
        _logger.Log(message, LogType.Fatal, ex);
    }
}