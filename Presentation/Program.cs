using System.Runtime.Intrinsics.Arm;

public class Program {
    static void Main(string[] args)
    {
        NotificationRepository repository = new NotificationRepository();

        NotificationService service = new NotificationService(repository);

        User user = null;

        while(true)
        {
            System.Console.WriteLine("enter your choice");
            string ?choice = Console.ReadLine();

            switch(choice)
            {
                case "1":
                    System.Console.WriteLine("enter name:");
                    string ?name = Console.ReadLine();
                    System.Console.WriteLine("enter email:");
                    string ?email = Console.ReadLine();
                    System.Console.WriteLine("enter number:");
                    string ?phoneno = Console.ReadLine();

                    user = new User(name, email, phoneno);
                    break;


                case "2":
                    string notificationType;
                    System.Console.WriteLine("enter notification type(1/2):");
                    string ?notificationChoice = Console.ReadLine();
                    if (notificationChoice == "1")
                    {
                        notificationType = "Email";
                    }
                    else if (notificationChoice == "2")
                    {
                        notificationType = "SMS";
                    }
                    else
                    {
                        Console.WriteLine("Invalid notification type.");
                        break;
                    }
                    System.Console.WriteLine("enter message:");
                    string message = Console.ReadLine();

                    Notification notification = new Notification(message, notificationType, DateTime.Now);
                    
                    service.SendNotification(user, notification);

                    break;

                case "3":
                    List<Notification> notifications = service.ReturnNotifications();
                    if(notifications.Count == 0) Console.WriteLine("No notifications");
                    else {
                        for(int i = 0; i < notifications.Count; i++)
                        {
                            System.Console.WriteLine(notifications[i].Message);
                        }
                    }
                    break;

                case "4": 
                    System.Console.WriteLine("bye");
                    break;
                
                default:
                    System.Console.WriteLine("invalid choice");
                    break;

            }
        }
    }
}
