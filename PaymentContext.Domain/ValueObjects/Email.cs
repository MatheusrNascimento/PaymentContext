using Flunt.Validations;
using PaymentContext.Shared.ValueObjects;

namespace PaymentContext.Domain.ValueObjects
{
    public class Email : ValueObjet
    {
        public Email(string address)
        {
            Address = address;

            
        }

        public string Address { get; private set; }
    }
}