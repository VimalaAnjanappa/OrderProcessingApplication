namespace OrderProcessing.ReceiptService
{
    public class GeneratePackingSlip
    {
        public virtual string CreateSlip(string order)
        {
            // BL to print slip
            return $"Printed Packing Slip for {order}.";
        }
    }
}
