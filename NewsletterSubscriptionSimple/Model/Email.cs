namespace NewsletterSubscriptionSimple.Model
{
    internal class Email
    {
        public string To { get; private set; }
        public string From { get; private set; }
        public string Subject{ get; private set; }
        public string Text { get; private set; }

        public Email(string to, string from, string subject, string text)
        {
            To = to;
            From = from;
            Subject = subject;
            Text = text;
        }
    }
}
