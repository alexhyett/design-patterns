public class BadLogger : IBadLogger
{
    public void Log(string message, LogType logType, LogTarget target, Exception? ex)
    {
        Console.WriteLine($"{DateTime.UtcNow:s} [{logType.ToString().ToUpper()}] {message}");

        if (ex != null)
        {
            Console.WriteLine("Exception:");
            Console.WriteLine(ex.Message);
            Console.WriteLine(ex.StackTrace);
        }
    }
}