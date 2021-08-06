namespace OrderProcessing.PaymentServices
{
    public class ProductProcessing
    {
        public ProductType GetDischargedTypeProduct()
        {
            return ProductType.Physical;
        }
    }

    public enum ProductType
    {
        Physical,
        Virtual
    }
}
