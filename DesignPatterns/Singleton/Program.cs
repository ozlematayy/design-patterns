#region Usage
var singleton = Singleton.Instance();
singleton.Log();
#endregion

#region Singleton Definition
class Singleton
{
    private static Singleton _singleton;
    static object _lockObj = new Object();
    private Singleton(){}

    public static Singleton Instance()
    {
        lock(_lockObj)
        {
            if(_singleton == null)
            {
                _singleton = new Singleton();
            }
        }
        return _singleton;
    }
    public void Log()
    {
        Console.WriteLine("Object creation process has been successfully completed.");
    }
}
#endregion

