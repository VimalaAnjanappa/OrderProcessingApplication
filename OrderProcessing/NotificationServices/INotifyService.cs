namespace OrderProcessing.NotificationServices
{
    public interface INotifyService
    {
        string SendMessage(string memberId, string message);
    }
}
