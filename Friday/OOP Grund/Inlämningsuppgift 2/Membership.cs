namespace Inlämningsuppgift_2
{
    public class Membership
    {
        private string _membershipStatus;
        private int _startDate;
        private int _endDate;

        public Membership(string membershipStatus)
        {
            _membershipStatus = membershipStatus;
        }

        public string MembershipStatus
        {
            get { return _membershipStatus; }
            set { _membershipStatus = value; }
        }

        public int StartDate
        {
            get { return _startDate; }
            set { _startDate = value; }
        }

        public int EndDate
        {
            get { return _endDate; }
            set { _endDate = value; }
        }

        public void ShowMembershipStatus()
        {
            Console.WriteLine($"Your membership is currently {MembershipStatus}, it starts on {StartDate} and expires on {EndDate}.\n");
        }

        public void RenewMembership()
        {
            Console.WriteLine("Do you wish to renew your membership?\n");
        }

        public void CancelMembership()
        {
            Console.WriteLine("Do you wish to cancel your membership?\n");
        }
    }
}
