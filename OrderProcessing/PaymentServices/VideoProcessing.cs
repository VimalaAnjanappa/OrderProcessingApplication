namespace OrderProcessing.PaymentServices
{
    public class VideoProcessing : IPaymentBookOrVideo
    {
        public string GetDischargedOrder()
        {
            // BL for getting name of video ordered
            return "Learning to Ski";
        }
    }
}
