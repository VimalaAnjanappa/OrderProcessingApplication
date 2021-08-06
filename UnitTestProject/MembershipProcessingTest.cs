using OrderProcessing.NotificationServices;
using OrderProcessing.PaymentServices;
using Xunit;

namespace UnitTestProject
{
    public class MembershipProcessingTest
    {
        [Fact]
        public void PaymentToActivateMembershipTest()
        {
            //Arrange
            MembershipProcessing membership = new MembershipProcessing(new EmailService());

            //Act
            string paymentProcess = membership.ActivateMember("xyz");

            //Assert
            Assert.Equal("Email sent to 123 for Member Activation", paymentProcess);
            Assert.NotEqual("Email sent to 123", paymentProcess);
        }

        [Fact]
        public void PaymentToUpgradeMembershipTest()
        {
            //Arrange
            MembershipProcessing membership = new MembershipProcessing(new EmailService());

            //Act
            string paymentProcess = membership.UpgradeMember("xyz");

            //Assert
            Assert.Equal("Email sent to xyz for Member Upgrade", paymentProcess);
            Assert.NotEqual("Email sent to 123", paymentProcess);
        }
    }
}
