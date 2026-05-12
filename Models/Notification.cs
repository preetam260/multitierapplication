using System;

public class Notification
{
    public string Message {get; set;}
    public DateTime TimeSent {get; set;}
    public string NotificationType {get; set;}

    public Notification(string message, string notificationType, DateTime timeSent)
    {
        this.Message = message;
        this.NotificationType = notificationType;
        this.TimeSent = DateTime.Now;
    }
}