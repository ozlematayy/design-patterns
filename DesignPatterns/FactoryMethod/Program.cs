#region Product
public interface ILogger
{
    void Log(string message);
}

#endregion
#region Concrete Product
public class ConsoleLogger : ILogger
{
    public void Log(string message)
    {
        Console.WriteLine($"Console Logger: {message}");
    }
}

public class DatabaseLogger : ILogger
{
    public void Log(string message)
    {
        Console.WriteLine($"Database Logger: {message}");
    }
}
#endregion
#region Concrete Creator
public class LoggerFactory
{
    public ILogger GetLogger(string loggerType)
    {
        if (loggerType.Equals("Console"))
        {
            return new ConsoleLogger();
        }
        else if (loggerType.Equals("Database"))
        {
            return new DatabaseLogger();
        }
        else
        {
            throw new ArgumentException("Invalid logger type!");
        }
    }
}
#endregion
#region Client
public class LoggingClient
{
    private readonly LoggerFactory loggerFactory;

    public LoggingClient(LoggerFactory factory)
    {
        loggerFactory = factory;
    }

    public void LogMessage(string message, string loggerType)
    {
        ILogger logger = loggerFactory.GetLogger(loggerType);
        logger.Log(message);
    }
}
#endregion
#region Running the code.
class Program
{
    static void Main(string[] args)
    {
        LoggerFactory loggerFactory = new LoggerFactory();
        LoggingClient loggingClient = new LoggingClient(loggerFactory);

        loggingClient.LogMessage("This message will be logged in a console.", "Console");
        loggingClient.LogMessage("This message will be logged in a database.", "Database");
        //loggingClient.LogMessage("This message will be logged in a database.", "Email");
    }
}
#endregion
