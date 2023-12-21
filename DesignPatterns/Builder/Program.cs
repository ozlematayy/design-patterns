#region Product Class
public class Log
{
    public string Message { get; set; }
    public string LogLevel { get; set; }

    public override string ToString()
    {
        return $"{LogLevel}: {Message}";
    }
}
#endregion

#region  Builder Interface
public interface ILogBuilder
{
    void SetMessage(string message);
    void SetLogLevel(string logLevel);
    Log GetLog();
}
#endregion

#region Concrete Builder
public class FileLogBuilder : ILogBuilder
{
    private Log _log = new Log();

    public void SetMessage(string message)
    {
        _log.Message = message;
    }

    public void SetLogLevel(string logLevel)
    {
        _log.LogLevel = logLevel;
    }

    public Log GetLog()
    {
        Console.WriteLine("File logging is performed!");
        return _log;
    }
}

public class EmailLogBuilder : ILogBuilder
{
    private Log _log = new Log();

    public void SetMessage(string message)
    {
        _log.Message = message;
    }

    public void SetLogLevel(string logLevel)
    {
        _log.LogLevel = logLevel;
    }

    public Log GetLog()
    {
        Console.WriteLine("Email logging is performed!");
        return _log;
    }
}
#endregion

#region Director Class
public class LogManager
{
    private readonly ILogBuilder _logBuilder;

    public LogManager(ILogBuilder logBuilder)
    {
        _logBuilder = logBuilder;
    }

    public Log BuildLog(string message, string logLevel)
    {
        _logBuilder.SetMessage(message);
        _logBuilder.SetLogLevel(logLevel);
        return _logBuilder.GetLog();
    }
}
#endregion

#region Running the code
class Program
{
    static void Main(string[] args)
    {
        var fileLogBuilder = new FileLogBuilder();
        var fileLogManager = new LogManager(fileLogBuilder);

        var fileLog = fileLogManager.BuildLog("Error occurred!", "ERROR");
        Console.WriteLine(fileLog);

        var emailLogBuilder = new EmailLogBuilder();
        var emailLogManager = new LogManager(emailLogBuilder);

        var emailLog = emailLogManager.BuildLog("Critical error!", "CRITICAL");
        Console.WriteLine(emailLog);
    }
}
#endregion
