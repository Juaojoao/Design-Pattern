using Factory.Service;

namespace Factory.Controller;

public class NotificationController
{
    public void SendNotification(string notificationType, string recipient, string message)
    {
        var notification = NotificationFactory.Create(notificationType);
        notification.Send(message, recipient);
    }
}