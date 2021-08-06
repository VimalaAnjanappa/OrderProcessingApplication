using OrderProcessing.CommissionService;
using OrderProcessing.PaymentServices;
using OrderProcessing.ReceiptService;
using Xunit;

namespace UnitTestProject
{
    public class ProductProcessingTest
    {
        [Fact]
        public void GetDischargedTypeProductTest()
        {
            //Arrange
            ProductProcessing product = new ProductProcessing();
            ProductType pType = product.GetDischargedTypeProduct("xyz@abc.com");

            //Act
            if (pType == ProductType.Physical)
            {
                string slipDetail = new SlipForShipping().CreateSlip(pType.ToString() + " Product");
                //Assert
                Assert.Equal($"Printed Packing Slip for {pType.ToString()} Product.Slip sent along shipping", slipDetail);

                Commission commission = new Agent();
                string commissionPaid = commission.MakePayment(1234);
                //Assert
                Assert.Equal($"Generate commission payment of 1234 to Agent", commissionPaid);
            }
        }

    }
}
