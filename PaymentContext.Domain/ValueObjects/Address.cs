using PaymentContext.Shared.ValueObjects;

namespace PaymentContext.Domain.ValueObjects
{
    public class Address : ValueObjet
    {
        public Address(string street, string number, string neighborhood, string zipCode, string state, string country, string city)
        {
            Street = street;
            Number = number;
            Neighborhood = neighborhood;
            ZipCode = zipCode;
            State = state;
            Country = country;
            City = city;
        }

        public string Street { get; private set; }
        public string Number { get; private set; }
        public string Neighborhood { get; private set; }
        public string ZipCode { get; private set; }
        public string State { get; private set; }
        public string Country { get; private set; }
        public string City { get; private set; }
    }
}