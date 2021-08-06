namespace OrderProcessing.PaymentServices
{
    public class ProductProcessing
    {
        public ProductType GetDischargedTypeProduct(string memberId)
        {
            //BL to get payment processed for order using memberId
            return ProductType.Physical;
        }
    }

    public enum ProductType
    {
        Physical,
        Virtual
    }
}
