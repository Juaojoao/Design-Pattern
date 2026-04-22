using Factory.Controller;

NotificationController notificationController = new NotificationController();

Console.WriteLine("For send a message, please, select a type message.");
Console.WriteLine("==============================");
Console.WriteLine("1 - Email");
Console.WriteLine("2 - SMS");
Console.WriteLine("3 - Whatsapp");
Console.WriteLine("==============================");

var keyInfo = Console.ReadKey().KeyChar;
string notificationType = string.Empty;

Console.WriteLine();

switch (keyInfo)
{
    case '1':
        notificationType = "Email";
        break;
    case '2':
        notificationType = "SMS";
        break;
    case '3':
        notificationType = "WhatsApp";
        break;
    default:
        Console.WriteLine("Invalid option. Please select a valid notification type.");
        break;
}

Console.WriteLine(notificationType);

Console.WriteLine();

Console.WriteLine("Who do you want to send this message to?");

string recipient = Console.ReadLine() ?? string.Empty;

if (string.IsNullOrWhiteSpace(recipient))
{
    Console.WriteLine("Recipient cannot be empty.");
    return;
}

Console.WriteLine();

Console.WriteLine("Type your message");

string message = Console.ReadLine() ?? string.Empty;

if (string.IsNullOrWhiteSpace(message))
{
    Console.WriteLine("Message cannot be empty.");
    return;
}

Console.WriteLine();

notificationController.SendNotification(notificationType, recipient, message);