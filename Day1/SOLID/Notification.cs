using System;

public class NotificationService
{
	INotificationChannel NotificationChannel { get; set; }
	public NotificationService(INotificationChannel notificationChannel)
	{
		NotificationChannel = notificationChannel;

		NotificationService.SendNotification(NotificationChannel(IContent content);
	}
}

public interface IContent
{
	public Stream ConvertToStream();
}

public class RichText : IContent
{
	public Stream ConvertToStream()
	{
		//convert html and attachments to stream
	}
}

public class PlainText : IContent
{
    public Stream ConvertToStream()
    {
        //convert text up to 160 chars to stream
    }
}

public class ShortText : IContent
{
    public Stream ConvertToStream()
    {
        //convert short text to stream
    }
}


public interface INotificationChannel
{
	public void SendNotification(Stream stream);
}

public class Email : INotificationChannel
{
	public Email(IContent content) { }

	public void SendNotification()

}

public class SMS : INotificationChannel
{
    public SMS(IContent content) { }

    public void SendNotification()
}

public class PushNotification : INotificationChannel
{
    public PushNotification(IContent content) { }

    public void SendNotification()
}
