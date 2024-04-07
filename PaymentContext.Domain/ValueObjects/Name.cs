using PaymentContext.Shared.ValueObjects;

namespace PaymentContext.Domain.ValueObjects
{

    public class Name : ValueObjet
    {
        public Name(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;

            if(string.IsNullOrWhiteSpace(FirstName))
            AddNotification("Name.FirstName", "Nome Invalido");
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
    }
}