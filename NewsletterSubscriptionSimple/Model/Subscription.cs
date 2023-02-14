namespace NewsletterSubscriptionSimple.Model
{
    internal class Subscription
    {
        public string EmailAddress { get; private set; }
        public string VerificationCode { get; private set; }
        public bool IsVerified { get; private set; }

        public Subscription(string emailAddress, string verificationCode, bool isVerified)
        {
            EmailAddress = emailAddress;
            VerificationCode = verificationCode;
            IsVerified = isVerified;
        }

        public void Verify()
        {
            IsVerified = true;
        }
    }
}
