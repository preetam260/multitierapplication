public class EmailNotificationSender : INotificationSender
{
    public void Send(User user, Notification notification)
    {
        Console.WriteLine($"Email sent: To: {user.Name}, {user.Email} Message: {notification.Message} Time: {notification.TimeSent}");
    }
}