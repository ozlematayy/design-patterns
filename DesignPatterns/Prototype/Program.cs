#region Prototype
public abstract class Logger
{
    public abstract Logger Clone();
    public abstract void Log(string message);
    public string LogPath { get; set; }

}
#endregion

#region Concrete Prototype
public class FileLogger : Logger
{
    public override void Log(string message)
    {
        Console.WriteLine($"File Logger: {message}");
    }
    public override Logger Clone()
    {
        return (FileLogger)MemberwiseClone();
    }
}
#endregion

#region Running the code - Client
class Client
{
    static void Main(string[] args)
    {
        FileLogger file1 = new FileLogger()
        {
            LogPath = "log.txt"
        };
        file1.Log("Log message");
        Console.WriteLine($"File1 Log Path : {file1.LogPath}");

        var file2 = file1.Clone();
        Console.WriteLine($"File2 Log Path : {file2.LogPath}");
    }
}

#endregion