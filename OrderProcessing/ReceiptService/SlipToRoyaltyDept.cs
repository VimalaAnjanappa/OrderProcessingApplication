namespace OrderProcessing.ReceiptService
{
    public class SlipToRoyaltyDept : GeneratePackingSlip
    {
        public override string CreateSlip(string order)
        {
            return base.CreateSlip(order) + "Sending copy to RoyaltyDept";
        }
    }
}
