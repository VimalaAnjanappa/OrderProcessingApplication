using OrderProcessing.CommissionService;
using OrderProcessing.FreeOrderService;
using OrderProcessing.PaymentServices;
using OrderProcessing.ReceiptService;
using Xunit;

namespace UnitTestProject
{
    public class BookOrVideoProcessingTest
    {
        [Fact]
        public void GetDischargedOrderForBookTest()
        {
            //Arrange
            BookOrVideoProcessing bookOrVideoProcessing = new BookOrVideoProcessing();
            BookProcessing bookProcessing = new BookProcessing();

            //Act
            string bookName = bookOrVideoProcessing.GetDischargedOrder(bookProcessing, "xyz@abc.com");
            string slipDetail = new SlipToRoyaltyDept().CreateSlip(bookName + " Book");

            //Assert
            Assert.Equal($"Printed Packing Slip for {bookName} Book.Sending copy to RoyaltyDept", slipDetail);

            Commission commission = new Agent();
            string commissionPaid = commission.MakePayment(456);
            //Assert
            Assert.Equal($"Generate commission payment of 456 to Agent", commissionPaid);
        }

        [Fact]
        public void GetDischargedOrderForVideoTest()
        {
            //Arrange
            BookOrVideoProcessing bookOrVideoProcessing = new BookOrVideoProcessing();
            VideoProcessing videoProcessing = new VideoProcessing();

            //Act
            string videoName = bookOrVideoProcessing.GetDischargedOrder(videoProcessing, "xyz@abc.com");
            if (videoName == "Learning to Ski")
            {
                string slipDetail = new SlipWithFreeOrder(new FreeVideo(), "First Aid").CreateSlip(videoName + " Video");

                //Assert
                Assert.Equal($"Printed Packing Slip for {videoName} Video.Adding free First Aid Video", slipDetail);
            }
        }
    }
}
