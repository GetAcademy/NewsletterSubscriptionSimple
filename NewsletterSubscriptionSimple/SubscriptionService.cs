using NewsletterSubscriptionSimple.Model;
using NewsletterSubscriptionSimple.Services;

namespace NewsletterSubscriptionSimple
{
    internal class SubscriptionService
    {
        private readonly IEmailService _emailService;
        private readonly ISubscriptionRepository _subscriptionRepository;

        public SubscriptionService(IEmailService emailService, ISubscriptionRepository subscriptionRepository)
        {
            _subscriptionRepository = subscriptionRepository;
            _emailService = emailService;
        }
        public void Subscribe(string emailAddress)
        {
            var code = Guid.NewGuid().ToString();
            var email = new Email(emailAddress, "oss@getacademy.no", "bekreft nyhetsbrev", $"koden er: {code}");
            _emailService.Send(email);
            var subscription = new Subscription(emailAddress, code, false);
            _subscriptionRepository.Write(subscription);

        }

        public bool Verify(string emailAddress, string code)
        {
            var subscription = _subscriptionRepository.Read(emailAddress);
            if (subscription == null||subscription.VerificationCode!=code)
            {
                return false; 
            }

            subscription.Verify();
            _subscriptionRepository.Write(subscription);
            var email = new Email(emailAddress, "oss@getacademy.no", "påmeldt nyhetsbrev!", $"enjoy!");
            _emailService.Send(email);

            return true;
        }
    }
}
