using NewsletterSubscriptionSimple.Model;

namespace NewsletterSubscriptionSimple.Services
{
    internal interface ISubscriptionRepository
    {
        void Write(Subscription subscription);
        Subscription Read(string email);
    }
}
