public interface IBadLogger
{
    void Log(string message, LogType logType, LogTarget target, Exception? ex);
}