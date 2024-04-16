
using Flunt.Notifications;

namespace PaymentContext.Shared.Entities
{
    public abstract class BaseEntity : Notifiable
    {
        protected BaseEntity()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; private set; }
    }
}