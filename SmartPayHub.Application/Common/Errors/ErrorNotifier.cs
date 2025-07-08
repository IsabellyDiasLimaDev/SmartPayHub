using SmartPayHub.Application.Common.Enums;

namespace SmartPayHub.Application.Common.Errors
{
    public class ErrorNotifier
    {
        private readonly List<ErrorNotification> _notifications;

        public ErrorNotifier()
        {
            _notifications = new List<ErrorNotification>();
        }

        public void AddNotification(ErrorNotification notification)
        {
            _notifications.Add(notification);
        }

        public void AddNotification(string errorMessage)
        {
            _notifications.Add(new ErrorNotification(errorMessage));
        }

        public void AddNotFoundNotification(string errorMessage)
        {
            _notifications.Add(new ErrorNotification(errorMessage, ErrorType.NotFound));
        }
        public void AddUnauthorizedNotification(string errorMessage)
        {
            _notifications.Add(new ErrorNotification(errorMessage, ErrorType.Unauthorized));
        }
        public List<ErrorNotification> GetNotifications()
        {
            return _notifications;
        }
        public bool HasNotFoundNotification()
        {
            return _notifications.Any(
                n => n.Type != null && n.Type.Equals(ErrorType.NotFound));
        }
        public bool HasUnauthorizedFoundNotification()
        {
            return _notifications.Any(
                n => n.Type != null && n.Type.Equals(ErrorType.Unauthorized));
        }
        public bool HasNotification()
        {
            return _notifications.Any();
        }
    }
}
