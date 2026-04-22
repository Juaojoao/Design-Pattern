namespace Factory.Interface;

public interface INotification
{
    void Send(string message, string recipient);
}