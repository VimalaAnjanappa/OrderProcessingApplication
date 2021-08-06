using OrderProcessing.FreeOrderService;

namespace OrderProcessing.ReceiptService
{
    public class SlipWithFreeOrder : GeneratePackingSlip
    {
        private readonly IFreeOrderService _freeOrderService;
        private readonly string _orderName;

        public SlipWithFreeOrder(IFreeOrderService freeOrderService, string orderName)
        {
            _freeOrderService = freeOrderService;
            _orderName = orderName;
        }

        public override string CreateSlip(string order)
        {
            return base.CreateSlip(order) + _freeOrderService.AddFreeServiceToOrder(_orderName);
        }
    }
}
