using System;
using System.Collections.Generic;


public class NotificationRepository
{
    private List<Notification> sentNotifications = new List<Notification>();

    public void SaveNotificaiton(Notification notif)
    {
        sentNotifications.Add(notif);
    }

    public List<Notification> ReturnNotifications()
    {
        return sentNotifications;
    }
}