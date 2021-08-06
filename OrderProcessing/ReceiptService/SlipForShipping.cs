namespace OrderProcessing.ReceiptService
{
    public class SlipForShipping : GeneratePackingSlip
    {
        public override string CreateSlip(string order)
        {
            return base.CreateSlip(order) + "Slip sent along shipping";
        }
    }
}
