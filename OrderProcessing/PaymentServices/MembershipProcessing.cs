using OrderProcessing.NotificationServices;

namespace OrderProcessing.PaymentServices
{
    public class MembershipProcessing
    {
        private readonly INotifyService _notifyService;

        public MembershipProcessing(INotifyService notifyService)
        {
            _notifyService = notifyService;
        }

        public string ActivateMember(string memberName)
        {
            //BL to create member details
            return _notifyService.SendMessage("123", "Member Activation");
        }

        public string UpgradeMember(string memberId)
        {
            //BL to upgrade membership 
            return _notifyService.SendMessage(memberId, "Member Upgrade");
        }
    }
}
