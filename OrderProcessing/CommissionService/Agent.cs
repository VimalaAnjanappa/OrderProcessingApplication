namespace OrderProcessing.CommissionService
{
    public class Agent : Commission
    {
        public override string MakePayment(long amount)
        {
            return $"Generate commission payment of {amount} to Agent";
        }
    }
}
