

public class SmsNotificationSender : INotificationSender
{
    public void Send(User user, Notification notification)
    {
        Console.WriteLine($"SMS sent: To: {user.Name}, {user.PhoneNo} Message: {notification.Message} Time: {notification.TimeSent}");
    }
}