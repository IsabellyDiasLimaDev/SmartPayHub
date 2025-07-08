using SmartPayHub.Application.Common.Errors;

namespace SmartPayHub.Application.Common.Interfaces
{
    public interface IErrorNotifier
    {
        void AddNotification(ErrorNotification notification);
        void AddNotification(string errorMessage);
        void AddNotFoundNotification(string errorMessage);
        void AddUnauthorizedNotification(string errorMessage);
        List<ErrorNotification> GetNotifications();
        bool HasNotification();
        bool HasNotFoundNotification();
        bool HasUnauthorizedFoundNotification();
    }
}
