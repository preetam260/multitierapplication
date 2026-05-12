using System;

public class NotificationService
{
    public NotificationRepository repository;

    public NotificationService(NotificationRepository repository)
    {
        this.repository = repository;
    }
    public void SendNotification(User user, Notification notification)
    {

        if(string.IsNullOrEmpty(notification.Message)) {
            Console.WriteLine("Message cant be empty"); return;
        }
        if(notification.Message.Length < 5) {
            Console.WriteLine("Message length insufficient"); return;
        }

        INotificationSender sender;

        if(notification.NotificationType == "SMS") {
            if(notification.Message.Length > 160)
            {
                Console.WriteLine("messaeg cant be longer than 160 words"); return;
            }
            if(user.PhoneNo.Length != 10)
            {
                Console.WriteLine("invalid phone number"); return;
            }

            sender = new SmsNotificationSender();
        } else if(notification.NotificationType == "Email") {
            if(string.IsNullOrEmpty(user.Email) || !user.Email.Contains("@")) {
                System.Console.WriteLine("invalid email"); return;
            }
            sender = new EmailNotificationSender();
        } else {
            Console.WriteLine("Invalid notification type");
            return;
        }

        sender.Send(user, notification);

        // Save the notification to the data layer
        repository.SaveNotificaiton(notification);
    }

    public List<Notification> ReturnNotifications()
    {
        return repository.ReturnNotifications();
    }
}