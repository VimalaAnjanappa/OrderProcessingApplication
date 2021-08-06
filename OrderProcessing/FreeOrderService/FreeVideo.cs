namespace OrderProcessing.FreeOrderService
{
    public class FreeVideo : IFreeOrderService
    {
        public string AddFreeServiceToOrder(string orderName)
        {
            return $"Adding free {orderName} Video";
        }
    }
}
