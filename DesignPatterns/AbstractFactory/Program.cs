#region Abstract Product Interface
public interface ILogger
{
    void Log(string message);
}

#endregion

#region Concrete Product Implementations
public class FileLogger : ILogger
{
    public void Log(string message)
    {
        Console.WriteLine($"File Logger: {message}");
    }
}

public class NetworkLogger : ILogger
{
    public void Log(string message)
    {
        Console.WriteLine($"Network Logger: {message}");
    }
}

#endregion

#region Abstract Factory Interface
public interface ILoggerFactory
{
    ILogger CreateLogger();
}
#endregion

#region Concrete Factory Implementations
public class FileLoggerFactory : ILoggerFactory
{
    public ILogger CreateLogger()
    {
        return new FileLogger();
    }
}

public class NetworkLoggerFactory : ILoggerFactory
{
    public ILogger CreateLogger()
    {
        return new NetworkLogger();
    }
}
#endregion

#region Client
public class LoggingClient
{
    private readonly ILoggerFactory loggerFactory;

    public LoggingClient(ILoggerFactory factory)
    {
        loggerFactory = factory;
    }

    public void LogMessage(string message)
    {
        ILogger logger = loggerFactory.CreateLogger();
        logger.Log(message);
    }
}
#endregion
#region Running the code
class Program
{
    static void Main(string[] args)
    {
        ILoggerFactory fileLoggerFactory = new FileLoggerFactory();
        LoggingClient fileLoggingClient = new LoggingClient(fileLoggerFactory);
        fileLoggingClient.LogMessage("This message will be logged in a file.");

        ILoggerFactory networkLoggerFactory = new NetworkLoggerFactory();
        LoggingClient networkLoggingClient = new LoggingClient(networkLoggerFactory);
        networkLoggingClient.LogMessage("This message will be logged in a network.");
    }
}

#endregion