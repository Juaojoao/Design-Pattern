using Factory.Interface;
using Factory.Strategy;

namespace Factory.Service;

public class NotificationFactory
{
    public static INotification Create(string NotificationType)
    {
        if (NotificationType == "Email")
            return new Email();
        if (NotificationType == "WhatsApp")
            return new WhatsApp();
        if (NotificationType == "SMS")
            return new SMS();

        throw new ArgumentException("Invalid Notification Type");
    }
}