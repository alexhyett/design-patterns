using System;

// Using the bad logger
var badLogger = new BadLogger();

badLogger.Log("This is an information message", LogType.Info, null);
badLogger.Log("This is an error message", LogType.Error, null);

try
{
    throw new InvalidOperationException("Something went wrong");
}
catch (Exception ex)
{
    badLogger.Log("This is an error message with exception", LogType.Error, ex);
}

try
{
    throw new InvalidOperationException("Something went really wrong");
}
catch (Exception ex)
{
    badLogger.Log("This is a fatal error message", LogType.Fatal, ex);
}

// Using the good logger
ILogger logger = new Logger();

logger.Information("This is an information message");
logger.Error("This is an error message");

try
{
    throw new InvalidOperationException("Something went wrong");
}
catch (Exception ex)
{
    logger.Error("This is an error message with exception", ex);
}

try
{
    throw new InvalidOperationException("Something went really wrong");
}
catch (Exception ex)
{
    logger.Fatal("This is a fatal error message", ex);
}