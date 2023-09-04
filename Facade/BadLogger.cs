public class BadLogger
{
    public void Log(string message, LogType logType, Exception? ex)
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