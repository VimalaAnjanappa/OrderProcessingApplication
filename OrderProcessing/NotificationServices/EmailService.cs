namespace OrderProcessing.NotificationServices
{
    public sealed class EmailService : INotifyService
    {
        public string SendMessage(string memberId, string message)
        {
            // BL get member email address and send email
            return $"Email sent to {memberId} for {message}";
        }
    }
}
