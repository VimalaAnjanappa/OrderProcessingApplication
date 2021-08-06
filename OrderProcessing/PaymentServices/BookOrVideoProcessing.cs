namespace OrderProcessing.PaymentServices
{
    public class BookOrVideoProcessing
    {
        public string GetDischargedOrder(IPaymentBookOrVideo obj, string memberId)
        {
            return obj.GetDischargedOrder(memberId);
        }
    }
}
