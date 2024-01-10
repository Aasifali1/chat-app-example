using ChatAppExample.Services;

namespace ChatAppExample
{
    public class MessageSender
    {
        private readonly NotificationService _notificationService;
        MessageSender(NotificationService notificationService) 
        { 
            _notificationService = notificationService;
        }
        public void Send(string message)
        {

        }
    }
}
