namespace SmartPayHub.Application.Common.Errors
{
    public class ErrorNotification
    {
        public ErrorNotification(string message, Enum? type = null)
        {
            Message = message;

            if (type != null)
            {
                Type = type;
            }
        }

        public string Message { get; }
        public Enum? Type { get; }
    }
}
