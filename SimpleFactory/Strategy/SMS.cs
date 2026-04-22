using Factory.Interface;

namespace Factory.Strategy;

public class SMS : INotification
{
    public void Send(string message, string recipient)
    {
        Console.WriteLine($"Message: {message} recipient: {recipient}");
    }
}