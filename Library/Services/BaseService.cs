namespace LAB8.Library.Services;

public abstract class BaseService
{
    protected void Log(string message)
    {
        Console.WriteLine(message);
    }
}