namespace OrderProcessing.PaymentServices
{
    public class BookOrVideoProcessing
    {
        public string GetDischargedOrder(IPaymentBookOrVideo obj)
        {
            return obj.GetDischargedOrder();
        }
    }
}
