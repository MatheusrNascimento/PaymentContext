using PaymentContext.Domain.ValueObjects;
using PaymentContext.Shared.Entities;

namespace PaymentContext.Domain.Entities
{
    public class Studant : BaseEntity
    {
        private IList<Subscription> _subscriptions;
        public Studant(Name name, Document document, Email email)
        {
            Name = name;
            Email = email;
            Document = document;
            _subscriptions = new List<Subscription>();

            AddNotifications(name, document, email);
        }

        public Name Name { get; set; }
        public Document Document { get; set; }
        public Email Email { get; private set; }
        public Address Address { get; private set; }
        public IReadOnlyCollection<Subscription> Subscriptions { get { return _subscriptions.ToArray(); } }

        public void AddSubcription(Subscription subscription)
        {
            foreach(Subscription sub in Subscriptions)
            {
                sub.DefineAsActive(false);
            }

            _subscriptions.Add(subscription);
        }

    }
}