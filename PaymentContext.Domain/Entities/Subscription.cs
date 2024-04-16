
namespace PaymentContext.Domain.Entities
{
    public class Subscription
    {
        private IList<Payment> _payments;

        public Subscription( DateTime? expireDate)
        {
            CreateDate = DateTime.Now;
            LastUpdateDate = DateTime.Now;
            ExpireDate = expireDate;
            Active = true;
        }

        public DateTime CreateDate { get; private set; }
        public DateTime LastUpdateDate { get; private set; }
        public DateTime? ExpireDate { get; private set; }
        public bool Active { get; private set; }
        public List<Payment> Payments { get; private set; }


        public void DefineAsActive(bool activate) 
        {
            Active = activate;
            LastUpdateDate = DateTime.Now;
        }

    }
}