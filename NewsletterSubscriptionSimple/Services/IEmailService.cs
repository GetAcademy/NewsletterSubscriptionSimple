using NewsletterSubscriptionSimple.Model;

namespace NewsletterSubscriptionSimple.Services
{
    internal interface IEmailService
    {
        void Send(Email email);
    }
}
