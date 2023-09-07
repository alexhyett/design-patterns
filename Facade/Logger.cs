public class Logger : ILogger
{
    private readonly IBadLogger _logger;
    public Logger()
    {
        _logger = new BadLogger();
    }

    public void Information(string message)
    {
        _logger.Log(message, LogType.Info, LogTarget.Console, null);
    }

    public void Error(string message, Exception? ex = null)
    {
        _logger.Log(message, LogType.Error, LogTarget.Console, ex);
    }

    public void Fatal(string message, Exception? ex = null)
    {
        _logger.Log(message, LogType.Fatal, LogTarget.Console, ex);
    }
}