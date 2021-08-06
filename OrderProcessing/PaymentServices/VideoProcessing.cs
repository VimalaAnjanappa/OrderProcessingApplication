namespace OrderProcessing.PaymentServices
{
    public class VideoProcessing : IPaymentBookOrVideo
    {
        public string GetDischargedOrder(string memberId)
        {
            // BL for getting name of video ordered using memberId
            return "Learning to Ski";
        }
    }
}
